from flask import Flask, jsonify, request
from Kendall_Correlation import Kendall_Correlation
from Pearson_Correlation import Pearson_Correlation
from Spearman_Correlation import Spearman_Correlation

app = Flask(__name__)


@app.route("/Api/CorrelationCalculation/Process_Spearman_Correlation", methods=['POST'])
def Process_Spearman_Correlation():
    data = request.json
    print(data)
    X = data["X"]
    Y = data["Y"]
    R = data["R"]
    return jsonify(Spearman_Correlation(X, Y, R))


@app.route("/Api/CorrelationCalculation/Process_Pearson_Correlation", methods=['POST'])
def Process_Pearson_Correlation():
    data = request.json
    print(data)
    X = data["X"]
    Y = data["Y"]
    R = data["R"]
    return jsonify(Pearson_Correlation(X, Y, R))


@app.route("/Api/CorrelationCalculation/Process_Kendall_Correlation", methods=['POST'])
def Process_Kendall_Correlation():
    data = request.json
    print(data)
    X = data["X"]
    Y = data["Y"]
    R = data["R"]
    return jsonify(Kendall_Correlation(X, Y, R))


if __name__ == "__main__":
    app.run(host="0.0.0.0", port=5000)
