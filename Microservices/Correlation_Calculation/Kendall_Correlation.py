import numpy as np
import scipy.stats


def Kendall_Correlation(X, Y, R):
    try:
        X = np.array(X)
        Y = np.array(Y)

        if len(X) != len(Y):
            print(
                '---  X and Y must have the same length, Correlation will not be calculated ---')
            exit()
        else:
            X = [X[i:i + R] for i in range(0, len(X), R)]
            Y = [Y[i:i + R] for i in range(0, len(Y), R)]
            N = len(X)

        CORR = []
        print(N)
        print(X)
        print(Y)
        for i in range(N):
            if len(X[i]) == R:
                print(X[i])
                print(Y[i])
                sc = scipy.stats.kendalltau(X[i], Y[i])[0]
                if np.isnan(sc):
                    sc = None
                else:
                    sc = round(sc, 2)
                CORR.append(sc)

        print(CORR)
        return Result_Correlate_Two_Arrays(CORR, "", "").__dict__
    except Exception as ex:
        import traceback
        return Result_Correlate_Two_Arrays("An Error Occured!", repr(ex), traceback.format_exc()).__dict__


class Result_Correlate_Two_Arrays:
    def __init__(self, i_Result, Exception_Message, Stack_Trace):
        self.i_Result = i_Result
        self.Stack_Trace = Stack_Trace
        self.Exception_Message = Exception_Message
