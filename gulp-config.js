module.exports = function () {
    var outputRootPath = process.cwd() + "\\release";
    var config = {
        solutionName: "CBA.Store",
        apiProject: "./CBA.Store.Api/CBA.Store.Api.csproj",
        webProject: "./CBA.Store.Web/CBA.Store.Web.csproj",
        databaseLocation: "./CBA.Store.Database/bin/Release/*.*",
        apiTargetPath: outputRootPath + "/apiroot",
        webTargetPath: outputRootPath + "/wwwroot",
        databaseTarget: outputRootPath + "/database",
        buildConfiguration: "Release",
        buildToolsVersion: 15.0,
        buildMaxCpuCount: 0,
        buildVerbosity: "minimal",
        buildPlatform: "Any CPU",
        publishPlatform: "AnyCpu",
        runCleanBuilds: false
    };
    return config;
};
