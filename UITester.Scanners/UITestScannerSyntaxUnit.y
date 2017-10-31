%output=UITestScannerSyntaxUnit.cs 

%{
	public Parser(UITestScannerLexicalScanner.Scanner scanner) : base(scanner) { }
	public UITester.Model.UITester Tester{ get; set; }
%}

%union { 
	public string sVal;
	public ControlType ctVal;
	public UIElement uieVal;
	public TestEvent teVal;
}

%using System.IO
%using QUT;
%using UITester.Model.UIElements;
%using System.Windows.Automation;
%using UITester.Model.UITests;

%namespace UITestScannerSyntaxScanner

%start main_expression

%token <sVal> Text Identificator Comment
%token <ctVal> KButton KTree KTreeItem KCustom KGroup KThumb KDataGrid
%token <ctVal> KDataItem KToolTip KDocument KPane KHeader KHeaderItem
%token <ctVal> KTable KTitleBar KSeparator KSplitButton KText KToolBar
%token <ctVal> KTab KCalendar KCheckBox KComboBox KEdit KHyperlink
%token <ctVal> KImage KListItem KTabItem KMenu KList KMenuItem KProgressBar
%token <ctVal> KRadioButton KScrollBar KSlider KSpinner KStatusBar KMenuBar
%token <teVal> KClick KDClick KKClick KCtrlClick KSetFocus KSetText KCheck
%token <teVal> KUncheck KCollapse KExpand KScrollTo KItem KSelectCell 
%token <teVal> KSelectItem KGetText KIsToggleOn KIsExpanded 
%token <teVal> KGetItem KSelectedItem KColumnCount KRowCount
%token KWindow Kn Ku LeftBracket RightBracket LeftFBracket RightFBracket   
%token LeftSBracket RightSBracket Equil KAssert
%type <teVal> test_type
%type <ctVal> control_type
%type <uieVal> control_expression
%type <sVal> identificator_expression

%%

main_expression : window_expression { }
				;

window_expression :  init_window_expression LeftFBracket tests_expression close_window_expression { }
			    ;

init_window_expression : KWindow LeftBracket Text RightBracket {
					Tester.Become($3);
				}		
				;

close_window_expression : RightFBracket {
					Tester.Unbecome();
				}
				;
tests_expression : test_expression {  }
				| test_expression tests_expression { }
				;

test_expression : assignment_expression { }
				| event_expression { }
				| Comment { }
				;

event_expression : test_type identificator_expression {
					Tester.AddTest($2, $1);
				}
				| KAssert test_type identificator_expression Text {
					Tester.AddTest($3, $2, ParametersParser.Parse($4));
				}
				| KAssert LeftBracket Text RightBracket test_type identificator_expression Text {
					Tester.AddTest($6, $5, $3, ParametersParser.Parse($7));
				}
				;

identificator_expression : Identificator {
					$$ = $1;
				}
				| control_expression {
					string name = Convert.ToString($1.GetHashCode(), 16);

					if(!Tester.IsIdentificatorExist(name))
						Tester.AddIdentificator(name, $1);
						
					$$ = name;
				}
				;

assignment_expression : Identificator Equil control_expression {
					Tester.AddIdentificator($1, $3);
				}
				;

control_expression : control_type LeftSBracket Kn Text RightSBracket {
					$$ = new UIElement($4, null, $1);
				}
				| control_type LeftSBracket Ku Text RightSBracket {
					$$ = new UIElement(null, $4, $1);
				}
				;

test_type       : KClick {
					$$ = $1;
				}
				| KDClick {
					$$ = $1;
				}
				| KKClick {
					$$ = $1;
				}
				| KCtrlClick {
					$$ = $1;
				}
				| KSetFocus {
					$$ = $1;
				}
				| KSetText {
					$$ = $1;
				}
				| KCheck {
					$$ = $1;
				}
				| KUncheck {
					$$ = $1;
				}
				| KCollapse {
					$$ = $1;
				}
				| KExpand {
					$$ = $1;
				}
				| KScrollTo {
					$$ = $1;
				}
				| KItem {
					$$ = $1;
				}
				| KSelectCell {
					$$ = $1;
				}
				| KSelectItem {
					$$ = $1;
				}
				| KGetText {
					$$ = $1;
				}
				| KIsToggleOn {
					$$ = $1;
				}
				| KIsExpanded {
					$$ = $1;
				}
				| KGetItem {
					$$ = $1;
				}
				| KSelectedItem {
					$$ = $1;
				}
				| KColumnCount {
					$$ = $1;
				}
				| KRowCount {
					$$ = $1;
				}
				;

control_type    : KButton {
					$$ = $1;
				}
				| KTree {
					$$ = $1;
				}
				| KTreeItem {
					$$ = $1;
				}
				| KCustom {
					$$ = $1;
				}
				| KGroup {
					$$ = $1;
				}
				| KThumb {
					$$ = $1;
				}
				| KDataGrid {
					$$ = $1;
				}
				| KDataItem {
					$$ = $1;
				}
				| KToolTip {
					$$ = $1;
				}
				| KDocument {
					$$ = $1;
				}
				| KPane {
					$$ = $1;
				}
				| KHeader {
					$$ = $1;
				}
				| KHeaderItem {
					$$ = $1;
				}
				| KTable {
					$$ = $1;
				}
				| KTitleBar {
					$$ = $1;
				}
				| KSeparator {
					$$ = $1;
				}
				| KSplitButton {
					$$ = $1;
				}
				| KText {
					$$ = $1;
				}
				| KToolBar {
					$$ = $1;
				}
				| KTab {
					$$ = $1;
				}
				| KCalendar {
					$$ = $1;
				}
				| KCheckBox {
					$$ = $1;
				}
				| KComboBox {
					$$ = $1;
				}
				| KEdit {
					$$ = $1;
				}
				| KHyperlink {
					$$ = $1;
				}
				| KImage {
					$$ = $1;
				}
				| KListItem {
					$$ = $1;
				}
				| KTabItem {
					$$ = $1;
				}
				| KMenu {
					$$ = $1;
				}
				| KList {
					$$ = $1;
				}
				| KMenuItem {
					$$ = $1;
				}
				| KProgressBar {
					$$ = $1;
				}
				| KRadioButton {
					$$ = $1;
				}
				| KScrollBar {
					$$ = $1;
				}
				| KSlider {
					$$ = $1;
				}
				| KSpinner {
					$$ = $1;
				}
				| KStatusBar {
					$$ = $1;
				}
				| KMenuBar {
					$$ = $1;
				}
				;

%%