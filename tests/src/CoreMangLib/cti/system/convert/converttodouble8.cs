using System;

/// <summary>
/// Convert.ToDouble(System.Int64)
/// </summary>
public class ConvertToDouble8
{
    public static int Main()
    {
        ConvertToDouble8 testObj = new ConvertToDouble8();

        TestLibrary.TestFramework.BeginTestCase("for method: Convert.ToDouble(System.Int64)");
        if (testObj.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }

    public bool RunTests()
    {
        bool retVal = true;

        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        retVal = PosTest2() && retVal;
        retVal = PosTest3() && retVal;
        retVal = PosTest4() && retVal;

        return retVal;
    }

    #region Positive tests
    public bool PosTest1()
    {
        bool retVal = true;
        string c_TEST_DESC = "PosTest1: Verfify value is a random Int64... ";
        string c_TEST_ID = "P001";

        Int64 actualValue = TestLibrary.Generator.GetInt64(-55);

        TestLibrary.TestFramework.BeginScenario(c_TEST_DESC);

        try
        {
            Double resValue = Convert.ToDouble(actualValue);
            if (actualValue != resValue)
            {
                string errorDesc = "value is not " + resValue.ToString() + " as expected: Actual is " + actualValue.ToString();
                TestLibrary.TestFramework.LogError("001" + " TestId-" + c_TEST_ID, errorDesc);
                retVal = false;
            }


        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002", "unexpected exception occurs :" + e);
            retVal = false;
        }

        return retVal;
    }

    public bool PosTest2()
    {
        bool retVal = true;
        string c_TEST_DESC = "PosTest2: Verfify value is Int64.MaxValue... ";
        string c_TEST_ID = "P002";

        Int64 actualValue = Int64.MaxValue;

        TestLibrary.TestFramework.BeginScenario(c_TEST_DESC);

        try
        {
            Double resValue = Convert.ToDouble(actualValue);
            if (actualValue != resValue)
            {
                string errorDesc = "value is not " + resValue.ToString() + " as expected: Actual is " + actualValue.ToString();
                TestLibrary.TestFramework.LogError("003" + " TestId-" + c_TEST_ID, errorDesc);
                retVal = false;
            }


        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("004", "unexpected exception occurs :" + e);
            retVal = false;
        }

        return retVal;
    }

    public bool PosTest3()
    {
        bool retVal = true;
        string c_TEST_DESC = "PosTest3: Verfify value is Int64.MinValue... ";
        string c_TEST_ID = "P003";

        Int64 actualValue = Int64.MinValue;

        TestLibrary.TestFramework.BeginScenario(c_TEST_DESC);

        try
        {
            Double resValue = Convert.ToDouble(actualValue);
            if (actualValue != resValue)
            {
                string errorDesc = "value is not " + resValue.ToString() + " as expected: Actual is " + actualValue.ToString();
                TestLibrary.TestFramework.LogError("005" + " TestId-" + c_TEST_ID, errorDesc);
                retVal = false;
            }


        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("006", "unexpected exception occurs :" + e);
            retVal = false;
        }

        return retVal;
    }

    public bool PosTest4()
    {
        bool retVal = true;
        string c_TEST_DESC = "PosTest4: Verfify value is zero... ";
        string c_TEST_ID = "P004";

        Int64 actualValue = 0;

        TestLibrary.TestFramework.BeginScenario(c_TEST_DESC);

        try
        {
            Double resValue = Convert.ToDouble(actualValue);
            if (actualValue != resValue)
            {
                string errorDesc = "value is not " + resValue.ToString() + " as expected: Actual is " + actualValue.ToString();
                TestLibrary.TestFramework.LogError("007" + " TestId-" + c_TEST_ID, errorDesc);
                retVal = false;
            }


        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("008", "unexpected exception occurs :" + e);
            retVal = false;
        }

        return retVal;
    }
    #endregion
}
