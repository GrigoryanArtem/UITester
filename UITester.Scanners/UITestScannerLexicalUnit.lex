%namespace UITestScannerLexicalScanner
%using QUT;
%using QUT.Gppg;
%using System.Linq;
%using UITestScannerSyntaxScanner;
%using System.Windows.Automation;
%using UITester.Model.UIElements;

Comment ;[^\r\n]*\r\n
Text \"[^"]*\"
LeftBracket \(
RightBracket \)
LeftFBracket \{
RightFBracket \}
LeftSBracket \[
RightSBracket \]
Identificator [a-z][a-zA-Z0-9]*
Equil \=
KAssert ASSERT
KWindow WINDOW
KButton BUTTON
KTree TREE
KTreeItem TREE_ITEM
KCustom CUSTOM
KGroup GROUP
KThumb THUMB
KDataGrid DATA_GRID
KDataItem DATA_ITEM
KToolTip TOOL_TIP
KDocument DOCUMENT
KPane PANE
KHeader HEADER
KHeaderItem HEADER_ITEM
KTable TABLE
KTitleBar TITLE_BAR
KSeparator SEPARATOR
KSplitButton SPLIT_BUTTON
KText TEXT
KToolBar TOOL_BAR
KTab TAB
KCalendar CALENDAR
KCheckBox CHECK_BOX
KComboBox COMBO_BOX
KEdit EDIT
KHyperlink HYPER_LINK
KImage IMAGE
KListItem LIST_ITEM
KTabItem TAB_ITEM
KMenu MENU
KList LIST
KMenuItem MENU_ITEM
KProgressBar PROGRESS_BAR
KRadioButton RADIO_BUTTON
KScrollBar SCROLL_BAR
KSlider SLIDER
KSpinner SPINNER
KStatusBar STATUS_BAR
KMenuBar MENU_BAR
Kn N
Ku U
KClick CLICK
KDClick D_CLICK
KKClick K_CLICK
KCtrlClick CTRL_CLICK
KSetFocus SET_FOCUS
KSetText SET_TEXT
KCheck CHECK
KUncheck UNCHECK
KCollapse COLLAPSE
KExpand EXPAND
KScrollTo SCROLL_TO
KItem ITEM
KSelectCell SELECT_CELL
KSelectItem SELECT_ITEM
KGetText GET_TEXT
KIsToggleOn IS_TOGGLE_ON
KIsExpanded IS_EXPANDED
KSelectedItem SELECTED_ITEM
KColumnCount COLUMN_COUNT
KRowCount ROW_COUNT
KGetItem GET_ITEM

%%

{KWindow} {
	return (int)Tokens.KWindow;
}

{KButton} {
  yylval.ctVal = ControlType.Button;
	return (int)Tokens.KButton;
}

{KTree} {
  yylval.ctVal = ControlType.Tree;
	return (int)Tokens.KTree;
}

{KTreeItem} {
  yylval.ctVal = ControlType.TreeItem;
	return (int)Tokens.KTreeItem;
}

{KCustom} {
  yylval.ctVal = ControlType.Custom;
	return (int)Tokens.KCustom;
}

{KGroup} {
  yylval.ctVal = ControlType.Group;
	return (int)Tokens.KGroup;
}

{KThumb} {
  yylval.ctVal = ControlType.Thumb;
	return (int)Tokens.KThumb;
}

{KDataGrid} {
  yylval.ctVal = ControlType.DataGrid;
	return (int)Tokens.KDataGrid;
}

{KDataItem} {
  yylval.ctVal = ControlType.DataItem;
	return (int)Tokens.KDataItem;
}

{KToolTip} {
  yylval.ctVal = ControlType.ToolTip;
	return (int)Tokens.KToolTip;
}

{KDocument} {
  yylval.ctVal = ControlType.Document;
	return (int)Tokens.KDocument;
}

{KPane} {
  yylval.ctVal = ControlType.Pane;
	return (int)Tokens.KPane;
}

{KHeader} {
  yylval.ctVal = ControlType.Header;
	return (int)Tokens.KHeader;
}

{KHeaderItem} {
  yylval.ctVal = ControlType.HeaderItem;
	return (int)Tokens.KHeaderItem;
}

{KTable} {
  yylval.ctVal = ControlType.Table;
	return (int)Tokens.KTable;
}

{KTitleBar} {
  yylval.ctVal = ControlType.TitleBar;
	return (int)Tokens.KTitleBar;
}

{KSeparator} {
  yylval.ctVal = ControlType.Separator;
	return (int)Tokens.KSeparator;
}

{KSplitButton} {
  yylval.ctVal = ControlType.SplitButton;
	return (int)Tokens.KSplitButton;
}

{KText} {
  yylval.ctVal = ControlType.Text;
	return (int)Tokens.KText;
}

{KToolBar} {
  yylval.ctVal = ControlType.ToolBar;
	return (int)Tokens.KToolBar;
}

{KTab} {
  yylval.ctVal = ControlType.Tab;
	return (int)Tokens.KTab;
}

{KCalendar} {
  yylval.ctVal = ControlType.Calendar;
	return (int)Tokens.KCalendar;
}

{KCheckBox} {
  yylval.ctVal = ControlType.CheckBox;
	return (int)Tokens.KCheckBox;
}

{KComboBox} {
  yylval.ctVal = ControlType.ComboBox;
	return (int)Tokens.KComboBox;
}

{KEdit} {
  yylval.ctVal = ControlType.Edit;
	return (int)Tokens.KEdit;
}

{KHyperlink} {
  yylval.ctVal = ControlType.Hyperlink;
	return (int)Tokens.KHyperlink;
}

{KImage} {
  yylval.ctVal = ControlType.Image;
	return (int)Tokens.KImage;
}

{KListItem} {
  yylval.ctVal = ControlType.ListItem;
	return (int)Tokens.KListItem;
}

{KTabItem} {
  yylval.ctVal = ControlType.TabItem;
	return (int)Tokens.KTabItem;
}

{KMenu} {
  yylval.ctVal = ControlType.Menu;
	return (int)Tokens.KMenu;
}

{KList} {
  yylval.ctVal = ControlType.List;
	return (int)Tokens.KList;
}

{KMenuItem} {
  yylval.ctVal = ControlType.MenuItem;
	return (int)Tokens.KMenuItem;
}

{KProgressBar} {
  yylval.ctVal = ControlType.ProgressBar;
	return (int)Tokens.KProgressBar;
}

{KRadioButton} {
  yylval.ctVal = ControlType.RadioButton;
	return (int)Tokens.KRadioButton;
}

{KScrollBar} {
  yylval.ctVal = ControlType.ScrollBar;
	return (int)Tokens.KScrollBar;
}

{KSlider} {
  yylval.ctVal = ControlType.Slider;
	return (int)Tokens.KSlider;
}

{KSpinner} {
  yylval.ctVal = ControlType.Spinner;
	return (int)Tokens.KSpinner;
}

{KStatusBar} {
  yylval.ctVal = ControlType.StatusBar;
	return (int)Tokens.KStatusBar;
}

{KMenuBar} {
  yylval.ctVal = ControlType.MenuBar;
	return (int)Tokens.KMenuBar;
}

{Kn} {
	return (int)Tokens.Kn;
}

{Ku} {
	return (int)Tokens.Ku;
}

{KClick} {
  yylval.teVal = TestEvent.Click;
        return (int)Tokens.KClick;
}

{KDClick} {
  yylval.teVal = TestEvent.DClick;
        return (int)Tokens.KDClick;
}

{KKClick} {
  yylval.teVal = TestEvent.KClick;
        return (int)Tokens.KKClick;
}

{KCtrlClick} {
  yylval.teVal = TestEvent.CtrlClick;
        return (int)Tokens.KCtrlClick;
}

{KSetFocus} {
  yylval.teVal = TestEvent.SetFocus;
        return (int)Tokens.KSetFocus;
}

{KSetText} {
  yylval.teVal = TestEvent.SetText;
        return (int)Tokens.KSetText;
}

{KCheck} {
  yylval.teVal = TestEvent.Check;
        return (int)Tokens.KCheck;
}

{KUncheck} {
  yylval.teVal = TestEvent.Uncheck;
        return (int)Tokens.KUncheck;
}

{KCollapse} {
  yylval.teVal = TestEvent.Collapse;
        return (int)Tokens.KCollapse;
}

{KExpand} {
  yylval.teVal = TestEvent.Expand;
        return (int)Tokens.KExpand;
}

{KScrollTo} {
  yylval.teVal = TestEvent.ScrollTo;
        return (int)Tokens.KScrollTo;
}

{KItem} {
  yylval.teVal = TestEvent.Item;
        return (int)Tokens.KItem;
}

{KSelectCell} {
  yylval.teVal = TestEvent.SelectCell;
        return (int)Tokens.KSelectCell;
}

{KSelectItem} {
  yylval.teVal = TestEvent.SelectItem;
        return (int)Tokens.KSelectItem;
}

{KGetText} {
  yylval.teVal = TestEvent.GetText;
        return (int)Tokens.KGetText;
}

{KIsToggleOn} {
  yylval.teVal = TestEvent.IsToggleOn;
        return (int)Tokens.KIsToggleOn;
}

{KIsExpanded} {
  yylval.teVal = TestEvent.IsExpanded;
        return (int)Tokens.KIsExpanded;
}

{KSelectedItem} {
  yylval.teVal = TestEvent.SelectedItem;
        return (int)Tokens.KSelectedItem;
}

{KColumnCount} {
  yylval.teVal = TestEvent.ColumnCount;
        return (int)Tokens.KColumnCount;
}

{KRowCount} {
  yylval.teVal = TestEvent.RowCount;
        return (int)Tokens.KRowCount;
}

{KGetItem} {
  yylval.teVal = TestEvent.GetItem;
        return (int)Tokens.KGetItem;
}


{LeftBracket} {
	return (int)Tokens.LeftBracket;
}

{RightBracket} {
	return (int)Tokens.RightBracket;
}

{Text} {
  yylval.sVal = yytext.Substring(1, yytext.Length - 2);
	return (int)Tokens.Text;
}

{Comment} {
  yylval.sVal = yytext.Substring(1, yytext.Length - 2);
	return (int)Tokens.Comment;
}

{LeftFBracket} {
	return (int)Tokens.LeftFBracket;
}

{RightFBracket} {
	return (int)Tokens.RightFBracket;
}

{LeftSBracket} {
	return (int)Tokens.LeftSBracket;
}

{RightSBracket} {
	return (int)Tokens.RightSBracket;
}

{Identificator} {
  yylval.sVal = yytext;
	return (int)Tokens.Identificator;
}

{Equil} {
	return (int)Tokens.Equil;
}

{KAssert} {
	return (int)Tokens.KAssert;
}

[^ \r\n] {
LexError();
return (int)Tokens.EOF;
}

%{
  yylloc = new LexLocation(tokLin, tokCol, tokELin, tokECol);
%}

%%

public override void yyerror(string format, params object[] args)
{
  var ww = args.Skip(1).Cast<string>().ToArray();
  string errorMsg = string.Format("({0},{1}): Detect {2},  expected {3}", yyline, yycol, args[0], string.Join(" or ", ww));
  throw new SyntaxException(errorMsg);
}

public void LexError()
{
  string errorMsg = string.Format("({0},{1}): Unknown character {2}", yyline, yycol, yytext);
    throw new LexicalException(errorMsg);
}