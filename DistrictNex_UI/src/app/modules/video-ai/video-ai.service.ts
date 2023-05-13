import { HttpClient } from '@angular/common/http';
import { Injectable, OnDestroy } from '@angular/core';
import { ActivatedRouteSnapshot, Resolve, RouterStateSnapshot } from '@angular/router';
import { CommonService } from 'app/core/Services/common.service';
import { Camera_Lines, Face_Key_Response_List, Face_Target_Response_Category, Fetch_Face_Targets_Response, Fetch_Facial_Recognition_Reponse, Fetch_License_Plate_Recognition_Response, Fetch_License_Plate_Targets_Response, Fetch_Scenes_Response, Get_Countings_Response, Incident, License_Plate_Category, Params_Face_Search, Params_Face_Target_Key_Search, Params_Fetch_Face_Targets, Params_Fetch_Facial_Recognition, Params_Fetch_License_Plate_Recognition, Params_Fetch_License_Plate_Targets, Params_Fetch_Scenes, Params_Get_Camera_Lines, Params_Get_Countings, Params_Get_License_Plate_Scene, Params_Get_Scene_Info, Params_Send_Alerts_Email, Proxy, Scene_Details, Scene_Info, Search_Face_Target_Key_Response_List, Stream_Data, Vehicle_Counting, Video_ai_asset } from 'app/core/Services/proxy.service';
import { Detect_Face_Response, Params_Detect_Face_In_Image, ProxyExt } from 'app/core/Services/proxyExt.service';
import { SmartrSplashScreenService } from 'app/shared/components/splash-screen/splash-screen.service';
import { TimezoneService } from 'app/shared/services/timezone.service';
import { ReplaySubject, Subject } from 'rxjs';
import { Facial_Recognition_Filters } from './facial-recognition/facial-recognition-search/facial-recognition-search.component';

@Injectable({
    providedIn: 'root'
})
export class VideoAIService implements Resolve<any>, OnDestroy {
    vehicleTypes: string[];
    cameraLines: Camera_Lines[];

    imagesBehaviorSubject = new Subject<Fetch_Scenes_Response>();
    vehicleCountingSubject = new ReplaySubject<Vehicle_Counting>(1);
    countingSubject = new ReplaySubject<Get_Countings_Response[]>(1);
    faceSearchBehaviorSubject = new Subject<Face_Key_Response_List>();
    faceTargetsBehaviorSubject = new Subject<Fetch_Face_Targets_Response>();
    facialRecognitionBehaviorSubject = new Subject<Fetch_Facial_Recognition_Reponse>();
    faceTargetKeySearchBehaviorSubject = new Subject<Search_Face_Target_Key_Response_List>();
    licensePlateTargetsBehaviorSubject = new Subject<Fetch_License_Plate_Targets_Response>();
    licensePlateRecognitionBehaviorSubject = new Subject<Fetch_License_Plate_Recognition_Response>();

    constructor(
        private proxy: Proxy,
        public api: HttpClient,
        private proxyExt: ProxyExt,
        private CmSvc: CommonService,
        public TimezoneService: TimezoneService,
        private smartrSplashScreenService: SmartrSplashScreenService,
    ) { }

    resolve(route?: ActivatedRouteSnapshot, state?: RouterStateSnapshot, showSplashScreen = true, entityId = 1) {
        return new Promise<any>(resolve => {
            if (showSplashScreen) {
                this.smartrSplashScreenService.show();
            }
            Promise.all([
                this.GetVehicleTypes(),
                this.getCameraLines(),
                this.fetchFaceTargetCategories(),
                this.getStreamData(entityId),
            ]).then(() => {
                this.fetchLicensePlateCategories();
                this.smartrSplashScreenService.hide();
                this.CmSvc.oToggle_Module_Subject.next(true);
                resolve(true);
            })
        })
    }

    fetchPhotos(startDate: Date, endDate: Date, i_List_Selected_Video_ai_asset: Video_ai_asset[], i_List_Selected_Search_Categories: string, pageSize: number, pageIndex: number): Promise<Fetch_Scenes_Response> {
        return new Promise(resolve => {
            const oParams_Fetch_Scenes = new Params_Fetch_Scenes();
            oParams_Fetch_Scenes.START_DATE = this.TimezoneService.Transform_Date_To_Current_Timezone(startDate).toISOString();
            oParams_Fetch_Scenes.END_DATE = this.TimezoneService.Transform_Date_To_Current_Timezone(endDate).toISOString();
            oParams_Fetch_Scenes.List_Video_ai_asset = i_List_Selected_Video_ai_asset;
            oParams_Fetch_Scenes.QUERY = i_List_Selected_Search_Categories;
            oParams_Fetch_Scenes.PAGE = pageIndex;
            oParams_Fetch_Scenes.SIZE = pageSize;
            this.proxy.Fetch_Scenes(oParams_Fetch_Scenes).subscribe(result => {
                this.imagesBehaviorSubject.next(result);
                resolve(result);
            })
        })
    }

    fetchLicensePlateRecognition(startDate: Date, endDate: Date, i_List_Selected_Video_ai_asset: Video_ai_asset[], i_Selected_Vehicle_Type: string, pageIndex: number, pageSize: number, plateNumber: string): Promise<Fetch_License_Plate_Recognition_Response> {
        return new Promise((resolve, reject) => {
            const oParams_Fetch_License_Plate_Recognition = new Params_Fetch_License_Plate_Recognition();
            oParams_Fetch_License_Plate_Recognition.START_DATE = this.TimezoneService.Transform_Date_To_Current_Timezone(startDate).toISOString();
            oParams_Fetch_License_Plate_Recognition.END_DATE = this.TimezoneService.Transform_Date_To_Current_Timezone(endDate).toISOString();
            oParams_Fetch_License_Plate_Recognition.List_Video_ai_asset = i_List_Selected_Video_ai_asset;
            oParams_Fetch_License_Plate_Recognition.VEHICLE_TYPE = i_Selected_Vehicle_Type;
            oParams_Fetch_License_Plate_Recognition.PAGE = pageIndex;
            oParams_Fetch_License_Plate_Recognition.SIZE = pageSize;
            oParams_Fetch_License_Plate_Recognition.PLATE_NUMBER = plateNumber;
            this.proxy.Fetch_License_Plate_Recognition(oParams_Fetch_License_Plate_Recognition).subscribe(result => {
                this.licensePlateRecognitionBehaviorSubject.next(result);
                resolve(result);
            })
        })
    }

    fetchFacialRecognition(i_List_Selected_Video_ai_asset: Video_ai_asset[], facial_recognition_filters: Facial_Recognition_Filters, pageSize: number, pageIndex: number): Promise<Fetch_Facial_Recognition_Reponse> {
        return new Promise((resolve, reject) => {
            const oParams_Fetch_Facial_Recognition = new Params_Fetch_Facial_Recognition();
            oParams_Fetch_Facial_Recognition.START_DATE = this.TimezoneService.Transform_Date_To_Current_Timezone(facial_recognition_filters.startDate).toISOString();
            oParams_Fetch_Facial_Recognition.END_DATE = this.TimezoneService.Transform_Date_To_Current_Timezone(facial_recognition_filters.endDate).toISOString();
            oParams_Fetch_Facial_Recognition.List_Video_ai_asset = i_List_Selected_Video_ai_asset;
            oParams_Fetch_Facial_Recognition.CATEGORIES = facial_recognition_filters.List_Selected_Category ? facial_recognition_filters.List_Selected_Category.join() : '';
            oParams_Fetch_Facial_Recognition.AGE = facial_recognition_filters.Selected_Age_Group;
            oParams_Fetch_Facial_Recognition.GENDER = facial_recognition_filters.Selected_Gender;
            oParams_Fetch_Facial_Recognition.EMOTION = facial_recognition_filters.Selected_Emotion;
            oParams_Fetch_Facial_Recognition.HAS_MASK = facial_recognition_filters.HasMask;
            oParams_Fetch_Facial_Recognition.TARGET_NAME = facial_recognition_filters.Target_Name;
            oParams_Fetch_Facial_Recognition.SCORES = facial_recognition_filters.Recognition_Score ? facial_recognition_filters.Recognition_Score / 100 : null;
            oParams_Fetch_Facial_Recognition.PAGE = pageIndex;
            oParams_Fetch_Facial_Recognition.SIZE = pageSize;
            this.proxy.Fetch_Facial_Recognition(oParams_Fetch_Facial_Recognition).subscribe(result => {
                this.facialRecognitionBehaviorSubject.next(result);
                resolve(result);
            })
        })
    }

    faceTargetKeySearch(descriptor: string, limit: number, scores: number, page: number, size: number): Promise<Search_Face_Target_Key_Response_List> {
        return new Promise((resolve, reject) => {
            const oParams_Face_Target_Key_Search = new Params_Face_Target_Key_Search();
            oParams_Face_Target_Key_Search.DESCRIPTOR = descriptor;
            oParams_Face_Target_Key_Search.LIMIT = limit;
            oParams_Face_Target_Key_Search.SCORES = scores / 100;
            oParams_Face_Target_Key_Search.PAGE = page;
            oParams_Face_Target_Key_Search.SIZE = size;
            this.proxy.Face_Target_Key_Search(oParams_Face_Target_Key_Search).subscribe(result => {
                this.faceTargetKeySearchBehaviorSubject.next(result);
                resolve(result);
            })
        })
    }

    faceSearch(i_List_Selected_Video_ai_asset: Video_ai_asset[], descriptor: string, limit: number, scores: number, startDate: Date, endDate: Date, page: number, size: number): Promise<Face_Key_Response_List> {
        return new Promise((resolve, reject) => {
            const oParams_Face_Search = new Params_Face_Search();
            oParams_Face_Search.DESCRIPTOR = descriptor;
            oParams_Face_Search.LIMIT = limit;
            oParams_Face_Search.SCORES = scores / 100;
            oParams_Face_Search.START_DATE = this.TimezoneService.Transform_Date_To_Current_Timezone(startDate).toISOString();
            oParams_Face_Search.END_DATE = this.TimezoneService.Transform_Date_To_Current_Timezone(endDate).toISOString();
            oParams_Face_Search.PAGE = page;
            oParams_Face_Search.SIZE = size;
            oParams_Face_Search.List_Video_ai_asset = i_List_Selected_Video_ai_asset;
            this.proxy.Face_Search(oParams_Face_Search).subscribe(result => {
                this.faceSearchBehaviorSubject.next(result);
                resolve(result);
            })
        })
    }

    Detect_Face_In_Image(file: File): Promise<Detect_Face_Response> {
        return new Promise((resolve, reject) => {
            const oParams_Detect_Face_In_Image: Params_Detect_Face_In_Image = new Params_Detect_Face_In_Image();
            oParams_Detect_Face_In_Image.FormData = new FormData();
            oParams_Detect_Face_In_Image.FormData.append('file', file);
            this.proxyExt.Detect_Face_In_Image(oParams_Detect_Face_In_Image).subscribe(response => {
                if (response.body.i_Result != null) {
                    resolve(response.body.i_Result);
                } else {
                    resolve(null);
                }
            }, reject);
        });
    }

    fetchLicensePlateTargets(plateNumber: string = null, category: string = null, pageSize: number, pageIndex: number): Promise<Fetch_License_Plate_Targets_Response> {
        return new Promise((resolve, reject) => {
            const oParams_Fetch_License_Plate_Targets = new Params_Fetch_License_Plate_Targets();
            if (category) {
                oParams_Fetch_License_Plate_Targets.CATEGORY = category;
            }
            if (plateNumber) {
                oParams_Fetch_License_Plate_Targets.PLATE_NUMBER = plateNumber;
            }
            oParams_Fetch_License_Plate_Targets.PAGE = pageIndex;
            oParams_Fetch_License_Plate_Targets.SIZE = pageSize;
            this.proxy.Fetch_License_Plate_Targets(oParams_Fetch_License_Plate_Targets).subscribe(result => {
                this.licensePlateTargetsBehaviorSubject.next(result);
                resolve(result);
            })
        })
    }

    fetchFaceTargets(targetName: string = null, list: string = null, pageSize: number, pageIndex: number): Promise<Fetch_Face_Targets_Response> {
        return new Promise((resolve, reject) => {
            const oParams_Fetch_Face_Targets = new Params_Fetch_Face_Targets();
            oParams_Fetch_Face_Targets.CATEGORY = list;
            oParams_Fetch_Face_Targets.TARGET_NAME = targetName;
            oParams_Fetch_Face_Targets.PAGE = pageIndex;
            oParams_Fetch_Face_Targets.SIZE = pageSize;
            this.proxy.Fetch_Face_Targets(oParams_Fetch_Face_Targets).subscribe(result => {
                this.faceTargetsBehaviorSubject.next(result);
                resolve(result);
            })
        })
    }

    getSceneInfo(sceneId: number, videoAiInstanceId: number, object_type): Promise<Scene_Info> {
        return new Promise(resolve => {
            const oParams_Get_Scene_Info = new Params_Get_Scene_Info();
            oParams_Get_Scene_Info.VIDEO_AI_INSTANCE_ID = videoAiInstanceId;
            oParams_Get_Scene_Info.SCENE_ID = sceneId;
            oParams_Get_Scene_Info.OBJECT_TYPE = object_type;
            this.proxy.Get_Scene_Info(oParams_Get_Scene_Info).subscribe(result => {
                resolve(result);
            })
        })
    }

    getLicensePlateScene(sceneId: number, videoAiInstanceId: number): Promise<Scene_Details> {
        return new Promise((resolve, reject) => {
            const oParams_Get_License_Plate_Scene = new Params_Get_License_Plate_Scene();
            oParams_Get_License_Plate_Scene.VIDEO_AI_INSTANCE_ID = videoAiInstanceId;
            oParams_Get_License_Plate_Scene.SCENE_ID = sceneId;
            this.proxy.Get_License_Plate_Scene(oParams_Get_License_Plate_Scene).subscribe(result => {
                resolve(result);
            })
        })
    }

    getStreamData(ENTITY_ID: number = null): Promise<Stream_Data> {
        return new Promise(resolve => {
            if (this.CmSvc.oStream_Data && !ENTITY_ID) {
                resolve(this.CmSvc.oStream_Data)
            } else {
                this.proxy.Get_Stream_Data({ ENTITY_ID: ENTITY_ID }).subscribe(result => {
                    this.CmSvc.oStream_Data = result;
                    resolve(result);
                })
            }
        });
    }

    fetchLicensePlateCategories(): Promise<License_Plate_Category[]> {
        return new Promise((resolve) => {
            if (this.CmSvc.oList_License_Plate_Categories) {
                resolve(this.CmSvc.oList_License_Plate_Categories)
            } else {
                this.proxy.Fetch_License_Plate_Categories({ VIDEO_AI_INSTANCE_ID: 5 }).subscribe(result => {
                    this.CmSvc.oList_License_Plate_Categories = result;
                    resolve(result);
                });
            }
        });
    }

    fetchFaceTargetCategories(): Promise<Face_Target_Response_Category[]> {
        return new Promise((resolve, reject) => {
            if (this.CmSvc.oList_Face_Target_List) {
                resolve(this.CmSvc.oList_Face_Target_List)
            } else {
                this.proxy.Fetch_Face_Target_Categories({ VIDEO_AI_INSTANCE_ID: 5 }).subscribe(result => {
                    this.CmSvc.oList_Face_Target_List = result;
                    resolve(result);
                })
            }
        })
    }

    getCountingData(startDate: Date, endDate: Date, measure: string, lineSetIdList: number[], typeList: string[]): Promise<Get_Countings_Response[]> {
        return new Promise(resolve => {
            const oParams_Get_Countings = new Params_Get_Countings();
            oParams_Get_Countings.VIDEO_AI_INSTANCE_ID = 1;
            oParams_Get_Countings.START_DATE = this.TimezoneService.Transform_Date_To_Current_Timezone(startDate).toISOString();
            oParams_Get_Countings.END_DATE = this.TimezoneService.Transform_Date_To_Current_Timezone(endDate).toISOString();
            oParams_Get_Countings.MEASURE = measure;
            oParams_Get_Countings.LINESET_ID_LIST = lineSetIdList;
            oParams_Get_Countings.TYPES = typeList;
            this.proxy.Get_Countings(oParams_Get_Countings).subscribe(result => {
                this.countingSubject.next(result);
                resolve(result);
            })
        })
    }

    getVehicleCounting(startDate: Date, endDate: Date, measure: string, lineSetIdList: number[], typeList: string[]): Promise<Vehicle_Counting> {
        return new Promise(resolve => {
            const oParams_Get_Countings = new Params_Get_Countings();
            oParams_Get_Countings.VIDEO_AI_INSTANCE_ID = 1;
            oParams_Get_Countings.START_DATE = this.TimezoneService.Transform_Date_To_Current_Timezone(startDate).toISOString();
            oParams_Get_Countings.END_DATE = this.TimezoneService.Transform_Date_To_Current_Timezone(endDate).toISOString();
            oParams_Get_Countings.MEASURE = measure;
            oParams_Get_Countings.LINESET_ID_LIST = lineSetIdList;
            oParams_Get_Countings.TYPES = typeList;
            this.proxy.Get_Vehicle_Countings(oParams_Get_Countings).subscribe(result => {
                this.vehicleCountingSubject.next(result);
                resolve(result);
            })
        })
    }

    GetVehicleTypes(ENTITY_ID: number = null): Promise<string[]> {
        return new Promise(resolve => {
            if (this.vehicleTypes) {
                resolve(this.vehicleTypes)
            } else {
                this.proxy.Get_Vehicle_Types({
                    ENTITY_ID: ENTITY_ID,
                    VIDEO_AI_INSTANCE_ID: 1
                }).subscribe(result => {
                    this.vehicleTypes = result;
                    resolve(result);
                })
            }
        })
    }

    getCameraLines(): Promise<Camera_Lines[]> {
        return new Promise(resolve => {
            if (this.cameraLines) {
                resolve(this.cameraLines)
            } else {
                const oParams_Get_Camera_Lines = new Params_Get_Camera_Lines();
                oParams_Get_Camera_Lines.VIDEO_AI_INSTANCE_ID = 1;
                this.proxy.Get_Camera_Lines(oParams_Get_Camera_Lines).subscribe(result => {
                    this.cameraLines = result;
                    resolve(result);
                })
            }
        })
    }

    Send_Alerts_Email(scene: Scene_Details, incident: Incident, email: string): Promise<boolean> {
        return new Promise((resolve, reject) => {
            let oParams_Send_Alerts_Email: Params_Send_Alerts_Email = new Params_Send_Alerts_Email();
            oParams_Send_Alerts_Email.Incident = incident;
            oParams_Send_Alerts_Email.Scene = scene;
            oParams_Send_Alerts_Email.TO_EMAIL = email;
            this.proxy.Send_Alerts_Email(oParams_Send_Alerts_Email).subscribe(result => {
                if (result) {
                    resolve(true);
                } else {
                    this.CmSvc.ShowMessage("An error has occured, please try again");
                    resolve(false);
                }
            });
        });
    }

    ngOnDestroy() {
        this.imagesBehaviorSubject.unsubscribe();
        this.countingSubject.unsubscribe();
        this.vehicleCountingSubject.unsubscribe();
    }
}
