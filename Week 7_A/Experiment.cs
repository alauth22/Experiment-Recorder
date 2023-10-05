using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_7_A
{
    //ENUM DECLARATION. Puts each value in the enum list equal to numbers.
    public enum ResultColor
    {
        Crimson, Azure, Taupe, Mauve, Vermillion, Chartreuse
    }

    //BEGINNING OF MY CLASS. 
    class Experiment
    {
        //FIELDS WHICH ARE PRIVATE. CHOSE TO DO BACKING FIELDS. 
        //Recall that the fields are just variables for storing data. 
        private string _studentName;
        private int _expNumber;
        private string _expDescription;
        private double _resultWeight;
        private double _resultVolume;
        //Need to grab the enum type which I named ResultColor. 
        private ResultColor _resultColor; 


        //OVERLOADED CONSTRUCTORS
        //Will allow for various parameters to be passed when creating the object. 
        //IF NOTHING IS KNOWN.
        public Experiment()
        {
            //First one is if nothing is known. 
            //So it has no parameters. 
        }

        //IF ONLY THE STUDENT NAME IS KNOWN.
        public Experiment(string StudName)
        {
            _studentName = StudName;
        }

        //IF ONLY EXPERIMENT NUMBER AND EXPERIMENT DESCRIPTION ARE KNOWN. 
        public Experiment(int ExpNum, string ExpDescrip)
        {
            _expNumber = ExpNum;
            _expDescription = ExpDescrip;
        }

        //IF ALL ARE CHOSEN. I chose do add this overloaded constructor. 
        public Experiment(int ExpNum, string StudName, string ExpDescrip)
        {
            _expNumber = ExpNum;
            _studentName = StudName;
            _expDescription = ExpDescrip;
        }


        //PUBLIC PROPERTIES
        //This will be the gets and sets for each field. 
        public string StudentName
        {
            get { return _studentName; }
            set { _studentName = value; }
        }

        public int ExpNum
        {
            get { return _expNumber; }
            set { _expNumber = value; }
        }

        public string ExpDescription
        {
            get { return _expDescription; }
            set { _expDescription = value; }
        }

        public double ResultWeight
        {
            get { return _resultWeight; }
            set { _resultWeight = value; }
        }

        public double ResultVolume
        {
            get { return _resultVolume; }
            set { _resultVolume = value; }
        }

        public ResultColor FinalResultColor
        {
            get { return _resultColor; }
            set { _resultColor = value; }
        }
        
    }
}
