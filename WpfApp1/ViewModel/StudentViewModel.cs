using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLDemoReadWrite.Model;

namespace XMLDemoReadWrite.ViewModel
{
    public class StudentViewModel : StudentViewModelBase
    {
        public StudentViewModel()
        {
            LoadStudentFromXMLFile();

            AddCommand = new RelayCommand(AddInvoke);
        }

        private void AddInvoke(object obj)
        {
            Student student = obj as Student;
            if (student!=null)
            {
                Students.Add(student);
                //save data
            }
        }

        private void LoadStudentFromXMLFile()
        {
            throw new NotImplementedException();
        }
        public void WriteStudentToXMLFile()
        {
            
        }
        public RelayCommand AddCommand { get; set; }
       
        public ObservableCollection<Student> Students
        {
            get;
            set;
        }
        private string _name;

        public string NameTemple
        {
            get { return _name; }
            set
            {
                if(value != _name)
                {
                    _name = value;
                    OnPropertyChange("NameTemple");
                    OnPropertyChange("StudentTemplate");
                }
            }
        }

        private int _age;

        public int AgeTemple
        {
            get { return _age; }
            set
            {
                if(value != _age)
                {
                    _age = value;
                    OnPropertyChange("AgeTemple");
                    OnPropertyChange("StudentTemplate");
                }
            }
        }

        private double _point;

        public double PointTemple
        {
            get { return _point; }
            set
            {
                if (value != _point)
                {
                    _point = value;
                    OnPropertyChange("PointTemple");
                    OnPropertyChange("StudentTemplate");
                }
            }
        }

        private Boolean _isValidate;

        public Boolean IsValidate
        {
            get { return _isValidate; }
            set
            {
                if (_point < 0 || _age < 0 )
                {
                    _isValidate = false;
                    
                }
                else
                {
                    _isValidate = true;
                }
                OnPropertyChange("IsValidate");
                OnPropertyChange("StudentTemplate");
            }
        }
        private Student _myStudent;

        public Student StudentTemplate
        {
            get { return _myStudent; }
            set
            {
                _myStudent.Age = AgeTemple;
                _myStudent.Name = NameTemple;
                _myStudent.Point = PointTemple;
                OnPropertyChange("StudentTemplate");
            }
        }

    }
}
