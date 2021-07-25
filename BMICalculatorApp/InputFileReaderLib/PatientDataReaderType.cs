using System;
using System.Collections.Generic;
using System.Text;

namespace InputFileReaderLib
{
    class PatientDataReaderType
    {
        public static List<InputFileReaderLib.PatientDetailsType> GetAllPatientsDetails(string path)
        {
            List<string> lines = GetAllLines(path);
            List<InputFileReaderLib.PatientDetailsType> patientList = new List<InputFileReaderLib.PatientDetailsType>();
            for (int i = 0; i < lines.Count; i++)
            {
                InputFileReaderLib.PatientDetailsType patientDataInfo = MapLineItemPatientObject(lines[i]);
                patientList.Add(patientDataInfo);

            }
            return patientList;
        }
        private static List<string> GetAllLines(string path)
        {
            List<string> lines = new List<string>();
            try
            {
                System.IO.StreamReader reader = new System.IO.StreamReader(path);
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    lines.Add(line);
                }
                reader.Close();
            }
            catch (SystemException)
            {
                ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay("Entered path is not correct Please enter Valid path");
            }
            return lines;
        }
        private static InputFileReaderLib.PatientDetailsType MapLineItemPatientObject(string lineItem)
        {
            string[] lineItems = lineItem.Split(',');
            InputFileReaderLib.PatientDetailsType patientData = new InputFileReaderLib.PatientDetailsType();
            patientData.Name = lineItems[0];
            patientData.Height = Int32.Parse(lineItems[1]);
            patientData.Weight = Int32.Parse(lineItems[2]);
            return patientData;
        }
    }
}

