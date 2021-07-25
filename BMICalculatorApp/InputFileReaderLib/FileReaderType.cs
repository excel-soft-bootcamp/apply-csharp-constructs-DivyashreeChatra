using System;
using System.Collections.Generic;
using System.Text;

namespace InputFileReaderLib
{
    public class FileReaderType
    {
        public static void Input(string path)
        {
            List<PatientDetailsType> patients = PatientDataReaderType.GetAllPatientsDetails(path);
            for (int i = 0; i < patients.Count; i++)
            {
                InputFileReaderLib.PatientDetailsType dataInfo = patients[i];

                float bmiValue = BMICalculateLib.CalculateBMIValueType.BmiCalculation(dataInfo.Weight, dataInfo.Height);
                string result = BMIValueValidateLib.ValidateBMIValueType.ValidateBMIValue(bmiValue);
                ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay(dataInfo.Name + "\t\t" + dataInfo.Height + "\t" + dataInfo.Weight + "\t" + bmiValue + "\t\t" + result);
            }
        }

    }
}
