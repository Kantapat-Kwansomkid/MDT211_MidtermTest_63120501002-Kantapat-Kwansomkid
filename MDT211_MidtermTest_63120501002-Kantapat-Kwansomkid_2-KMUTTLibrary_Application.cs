using System;

namespace MDT211_MidtermTest_63120501002-Kantapat-Kwansomkid_2-KMUTTLibrary_Application
{
    public class Home
    {
        string ConectionString = "Welcome to Digital Library";  
        public KMUTTLibrary connection = null;
        public string user = "Input name:";
        public string password = "Input Password:";
        DataSet ds;
        DataTable dt;
        public string Table = "Input User Type 1 = Student, 2 = Employee:"; 
        public string ConnectionType = "Student ID:";
        string RecordSource = "Register new Person";

        DataGridView tempdata;

        public Home()
        {
            KMUTTLibrary = "";
        }

        public void Connect(string database_name)
        {
            try
            {
                ConectionString = "SERVER =" + ";" + "DATABASE =" + database_name + ";" + "UID =" + user + ";" + "PASSWORD =" + password + ";";

                connection = new KMUTTLibrary(ConectionString);
            }
           
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }

        public void KMUTTLibrary(string KMUTTLibrary)
        {
            nowquiee(KMUTTLibrary);
        }

         public void nowquiee(string KMUTTLibrary)
         {
            try
            {
                KMUTTLibrary cs = new KMUTTLibraryConnection(ConectionString);
                cs.Open();
                KMUTTLibraryCommand myc = new KMUTTLibraryCommand(KMUTTLibrary, cs);
                myc.ExecuteNonQuery();
                cs.Close();
            }
 
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
         }

        public void Execute(string KMUTTLibrary)
        {
            RecordSource = KMUTTLibrary;
            ConnectionType = Table;
            dt = new DataTable(ConnectionType);
            try
            {
                string command = RecordSource.ToUpper();

                KMUTTLibraryDataAdapter da2 = new KMUTTLibraryDataAdapter(RecordSource, connection);

                DataSet tempds = new DataSet();
                da2.Fill(tempds, ConnectionType);
                da2.Fill(tempds);
            }

            catch (Exception err) {Console.WriteLine(err.Message); }
        }

        public string Results(int ROW, string COLUMN_NAME)
        {
            try
            {
                return dt.Rows[ROW][COLUMN_NAME].ToString();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return "";
            }
        }

        public string Results(int ROW, int COLUMN_NAME)
        {
            try
            {
                return dt.Rows[ROW][COLUMN_NAME].ToString();
            }
           
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return dt.Rows[ROW][COLUMN_NAME].ToString();

            }
        }

        public void ExecuteSelect(string KMUTTLibrary)
        {
            RecordSource = KMUTTLibrary;
            ConnectionType = Table;

            dt = new DataTable(ConnectionType);
            try
            {
                string command = RecordSource.ToUpper();
                KMUTTLibrary da = new KMUTTLibrary(RecordSource, connection);
                ds = new DataSet();
                da.Fill(ds, ConnectionType);
                da.Fill(dt);
                tempdata = new DataGridView();
            }
            
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        Console.ReadLine();
    }
}
