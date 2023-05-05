using System.Windows.Forms;

namespace Learning_System;

public partial class AddingNewQuiz : UserControl
{
    public AddingNewQuiz()
    {
        InitializeComponent();
        Controls.Add(AddNewQuizForm_HeadingLbl);
        Controls.Add(AddNewQuizForm_GeneralLbl);
        Controls.Add(AddNewQuizForm_NameTxt);
        Controls.Add(AddNewQuizFormTxt_Description);
        Controls.Add(AddNewQuizForm_NameLbl);
        Controls.Add(AddNewQuizFormLbl_Description);
        Controls.Add(AddNewQuizForm_DisplayTbt);
        Controls.Add(AddNewQuizForm_DisplayLbl);
        Controls.Add(AddNewQuizForm_LineLbl);
        Controls.Add(AddNewQuizForm_TiminglLbl);
        Controls.Add(AddNewQuizForm_OpenthequizLbl);
        Controls.Add(AddNewQuizForm_ClosethequizLbl);
        Controls.Add(AddNewQuizForm_Timelimit);
        Controls.Add(AddNewQuizForm_Timeexpires);
        Controls.Add(AddNewQuizForm_dateopenCbo);
        Controls.Add(AddNewQuizForm_MonthopenCbo);
        Controls.Add(AddNewQuizForm_YearopenCbo);
        Controls.Add(AddNewQuizForm_HouropenCbo);
        Controls.Add(AddNewQuizForm_MinuteopenCbo);
        Controls.Add(AddNewQuizForm_openTbt);
        Controls.Add(AddNewQuizForm_openLbl);
        Controls.Add(AddNewQuizForm_dateCloseCbo);
        Controls.Add(AddNewQuizForm_MonthCloseCbo);
        Controls.Add(AddNewQuizForm_YearCloseCbo);
        Controls.Add(AddNewQuizForm_HourCloseCbo);
        Controls.Add(AddNewQuizForm_MinuteCloseCbo);
        Controls.Add(AddNewQuizForm_CloseTbt);
        Controls.Add(AddNewQuizForm_CloseLbl);
        Controls.Add(AddNewQuizForm_TimelimiMinuteCbo);
        Controls.Add(AddNewQuizForm_TimelimitTbt);
        Controls.Add(AddNewQuizForm_TimelimitLbl);
        Controls.Add(AddNewQuizForm_TimeexpiresCloseCbo); 
    }
}