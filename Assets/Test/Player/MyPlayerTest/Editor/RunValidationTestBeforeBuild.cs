using UnityEngine;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEditor.TestTools.TestRunner.Api;

public class RunValidationTestBeforeBuild : IPreprocessBuildWithReport
{
    public int callbackOrder => 0;

    public void OnPreprocessBuild(BuildReport report)
    {
        var results = new ResultCollector();

        var api = ScriptableObject.CreateInstance<TestRunnerApi>();
        api.RegisterCallbacks(results);
        api.Execute(new ExecutionSettings
        {
            runSynchronously = true,

            filters = new[]
            {
                // CategoryNames is not obligatory, but recommend if you want to group your tests
                new Filter {
                    categoryNames = new [] {$"PlayerCategory" },
                    testMode = TestMode.EditMode
                }
            }
        });

        // If we found ANY errors, we can fail here
        if(results.Result.FailCount > 0)
            throw new BuildFailedException("Failed !");
    }

}
