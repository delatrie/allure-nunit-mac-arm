using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace Issue391.OldVersion;

[AllureNUnit]
public class MyTestClass
{
    [AllureStep]
    public void MyStep() { }

    [Test]
    public void RunStep()
    {
        this.MyStep();
    }
}
