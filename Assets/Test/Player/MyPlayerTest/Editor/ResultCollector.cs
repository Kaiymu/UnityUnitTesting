using UnityEditor.TestTools.TestRunner.Api;

public class ResultCollector : ICallbacks
{
    public ITestResultAdaptor Result { get; private set; }

    public void RunFinished(ITestResultAdaptor result)
    {
        Result = result;
    }

    public void RunStarted(ITestAdaptor testsToRun)
    {
    }

    public void TestFinished(ITestResultAdaptor result)
    {
    }

    public void TestStarted(ITestAdaptor test)
    {
    }
}
