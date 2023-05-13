import { Subject } from 'rxjs';
import { Injectable } from '@angular/core';
import { CommonService } from './common.service';
import { HttpTransportType, HubConnection, HubConnectionBuilder, LogLevel } from '@microsoft/signalr';

@Injectable({
    providedIn: 'root'
})
export class SignalrService {
    dataSubject = new Subject();
    oHubConnection: HubConnection;
    user_identifier = '';
    constructor(private CmSvc: CommonService) {
        this.user_identifier = `${this.CmSvc.oUser_Details.USER_ID}_Frontend`;
    }
    Initialize_SignalR_Hub_Connection(Hub: string) {
        this.oHubConnection = new HubConnectionBuilder()
            .withUrl(`${this.CmSvc.SignalR_Realtime_Server_Endpoint}/${Hub}`, {
                skipNegotiation: true,
                transport: HttpTransportType.WebSockets
            })
            .configureLogging(LogLevel.Information)
            .withAutomaticReconnect()
            .build();
    }
    async Open_SignalR_Connection() {
        await this.oHubConnection.start().then(() => {
            this.oHubConnection.invoke("Connect_User", this.user_identifier);
        });
    }
    Close_SignalR_Connection() {
        if (this.oHubConnection) {
            this.oHubConnection.invoke("Disconnect_User", this.user_identifier).then(_ => {
                this.oHubConnection.stop().then((_) => {
                    this.oHubConnection = null;
                });
            });
        }
    }
    Invoke_SignalR_Server(method: string, body): Promise<any> {
        return this.oHubConnection.invoke(method, body);
    }
    Receive(method: string) {
        if (!this.oHubConnection) {
            this.Initialize_SignalR_Hub_Connection(this.CmSvc.Signalr_Data_Hub);
            this.Open_SignalR_Connection();
            this.oHubConnection.on(method, (message) => {
                this.dataSubject.next(message);
            });
        }
    }
    ngOnDestroy() {
        this.dataSubject.unsubscribe();
    }
}
