// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, QUT 2005-2010
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.3.6
// Machine:  TURING
// DateTime: 08.11.2017 12:50:56
// UserName: artem
// Input file <UITestScannerSyntaxUnit.y>

// options: no-lines gplex

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using QUT.Gppg;
using System.IO;
using QUT;
using UITester.Model.UIElements;
using System.Windows.Automation;
using UITester.Model.UITests;

namespace UITestScannerSyntaxScanner
{
public enum Tokens {
    error=1,EOF=2,Text=3,Identificator=4,Comment=5,KButton=6,
    KTree=7,KTreeItem=8,KCustom=9,KGroup=10,KThumb=11,KDataGrid=12,
    KDataItem=13,KToolTip=14,KDocument=15,KPane=16,KHeader=17,KHeaderItem=18,
    KTable=19,KTitleBar=20,KSeparator=21,KSplitButton=22,KText=23,KToolBar=24,
    KTab=25,KCalendar=26,KCheckBox=27,KComboBox=28,KEdit=29,KHyperlink=30,
    KImage=31,KListItem=32,KTabItem=33,KMenu=34,KList=35,KMenuItem=36,
    KProgressBar=37,KRadioButton=38,KScrollBar=39,KSlider=40,KSpinner=41,KStatusBar=42,
    KMenuBar=43,KClick=44,KDClick=45,KKClick=46,KCtrlClick=47,KSetFocus=48,
    KSetText=49,KCheck=50,KUncheck=51,KCollapse=52,KExpand=53,KScrollTo=54,
    KItem=55,KSelectCell=56,KSelectItem=57,KGetText=58,KIsToggleOn=59,KIsExpanded=60,
    KGetItem=61,KSelectedItem=62,KColumnCount=63,KRowCount=64,KWindow=65,Kn=66,
    Ku=67,LeftBracket=68,RightBracket=69,LeftFBracket=70,RightFBracket=71,LeftSBracket=72,
    RightSBracket=73,Equil=74,KAssert=75};

public struct ValueType
{ 
	public string sVal;
	public ControlType ctVal;
	public UIElement uieVal;
	public TestEvent teVal;
}
// Abstract base class for GPLEX scanners
public abstract class ScanBase : AbstractScanner<ValueType,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

public class Parser: ShiftReduceParser<ValueType, LexLocation>
{
  // Verbatim content from UITestScannerSyntaxUnit.y
	public Parser(UITestScannerLexicalScanner.Scanner scanner) : base(scanner) { }
	public UITester.Model.UITester Tester{ get; set; }
  // End verbatim content from UITestScannerSyntaxUnit.y

#pragma warning disable 649
  private static Dictionary<int, string> aliasses;
#pragma warning restore 649
  private static Rule[] rules = new Rule[80];
  private static State[] states = new State[104];
  private static string[] nonTerms = new string[] {
      "main_expression", "test_type", "control_type", "control_expression", "identificator_expression", 
      "$accept", "window_expression", "init_window_expression", "tests_expression", 
      "close_window_expression", "test_expression", "assignment_expression", 
      "event_expression", };

  static Parser() {
    states[0] = new State(new int[]{65,100},new int[]{-1,1,-7,3,-8,4});
    states[1] = new State(new int[]{2,2});
    states[2] = new State(-1);
    states[3] = new State(-2);
    states[4] = new State(new int[]{70,5});
    states[5] = new State(new int[]{4,12,44,67,45,68,46,69,47,70,48,71,49,72,50,73,51,74,52,75,53,76,54,77,55,78,56,79,57,80,58,81,59,82,60,83,61,84,62,85,63,86,64,87,75,88,5,98,65,100},new int[]{-9,6,-11,9,-12,11,-13,61,-2,62,-7,99,-8,4});
    states[6] = new State(new int[]{71,8},new int[]{-10,7});
    states[7] = new State(-3);
    states[8] = new State(-5);
    states[9] = new State(new int[]{4,12,44,67,45,68,46,69,47,70,48,71,49,72,50,73,51,74,52,75,53,76,54,77,55,78,56,79,57,80,58,81,59,82,60,83,61,84,62,85,63,86,64,87,75,88,5,98,65,100,71,-6},new int[]{-9,10,-11,9,-12,11,-13,61,-2,62,-7,99,-8,4});
    states[10] = new State(-7);
    states[11] = new State(-8);
    states[12] = new State(new int[]{74,13});
    states[13] = new State(new int[]{6,23,7,24,8,25,9,26,10,27,11,28,12,29,13,30,14,31,15,32,16,33,17,34,18,35,19,36,20,37,21,38,22,39,23,40,24,41,25,42,26,43,27,44,28,45,29,46,30,47,31,48,32,49,33,50,34,51,35,52,36,53,37,54,38,55,39,56,40,57,41,58,42,59,43,60},new int[]{-4,14,-3,15});
    states[14] = new State(-18);
    states[15] = new State(new int[]{72,16});
    states[16] = new State(new int[]{66,17,67,20});
    states[17] = new State(new int[]{3,18});
    states[18] = new State(new int[]{73,19});
    states[19] = new State(-19);
    states[20] = new State(new int[]{3,21});
    states[21] = new State(new int[]{73,22});
    states[22] = new State(-20);
    states[23] = new State(-42);
    states[24] = new State(-43);
    states[25] = new State(-44);
    states[26] = new State(-45);
    states[27] = new State(-46);
    states[28] = new State(-47);
    states[29] = new State(-48);
    states[30] = new State(-49);
    states[31] = new State(-50);
    states[32] = new State(-51);
    states[33] = new State(-52);
    states[34] = new State(-53);
    states[35] = new State(-54);
    states[36] = new State(-55);
    states[37] = new State(-56);
    states[38] = new State(-57);
    states[39] = new State(-58);
    states[40] = new State(-59);
    states[41] = new State(-60);
    states[42] = new State(-61);
    states[43] = new State(-62);
    states[44] = new State(-63);
    states[45] = new State(-64);
    states[46] = new State(-65);
    states[47] = new State(-66);
    states[48] = new State(-67);
    states[49] = new State(-68);
    states[50] = new State(-69);
    states[51] = new State(-70);
    states[52] = new State(-71);
    states[53] = new State(-72);
    states[54] = new State(-73);
    states[55] = new State(-74);
    states[56] = new State(-75);
    states[57] = new State(-76);
    states[58] = new State(-77);
    states[59] = new State(-78);
    states[60] = new State(-79);
    states[61] = new State(-9);
    states[62] = new State(new int[]{4,65,6,23,7,24,8,25,9,26,10,27,11,28,12,29,13,30,14,31,15,32,16,33,17,34,18,35,19,36,20,37,21,38,22,39,23,40,24,41,25,42,26,43,27,44,28,45,29,46,30,47,31,48,32,49,33,50,34,51,35,52,36,53,37,54,38,55,39,56,40,57,41,58,42,59,43,60},new int[]{-5,63,-4,66,-3,15});
    states[63] = new State(new int[]{3,64,4,-12,44,-12,45,-12,46,-12,47,-12,48,-12,49,-12,50,-12,51,-12,52,-12,53,-12,54,-12,55,-12,56,-12,57,-12,58,-12,59,-12,60,-12,61,-12,62,-12,63,-12,64,-12,75,-12,5,-12,65,-12,71,-12});
    states[64] = new State(-13);
    states[65] = new State(-16);
    states[66] = new State(-17);
    states[67] = new State(-21);
    states[68] = new State(-22);
    states[69] = new State(-23);
    states[70] = new State(-24);
    states[71] = new State(-25);
    states[72] = new State(-26);
    states[73] = new State(-27);
    states[74] = new State(-28);
    states[75] = new State(-29);
    states[76] = new State(-30);
    states[77] = new State(-31);
    states[78] = new State(-32);
    states[79] = new State(-33);
    states[80] = new State(-34);
    states[81] = new State(-35);
    states[82] = new State(-36);
    states[83] = new State(-37);
    states[84] = new State(-38);
    states[85] = new State(-39);
    states[86] = new State(-40);
    states[87] = new State(-41);
    states[88] = new State(new int[]{68,92,44,67,45,68,46,69,47,70,48,71,49,72,50,73,51,74,52,75,53,76,54,77,55,78,56,79,57,80,58,81,59,82,60,83,61,84,62,85,63,86,64,87},new int[]{-2,89});
    states[89] = new State(new int[]{4,65,6,23,7,24,8,25,9,26,10,27,11,28,12,29,13,30,14,31,15,32,16,33,17,34,18,35,19,36,20,37,21,38,22,39,23,40,24,41,25,42,26,43,27,44,28,45,29,46,30,47,31,48,32,49,33,50,34,51,35,52,36,53,37,54,38,55,39,56,40,57,41,58,42,59,43,60},new int[]{-5,90,-4,66,-3,15});
    states[90] = new State(new int[]{3,91});
    states[91] = new State(-14);
    states[92] = new State(new int[]{3,93});
    states[93] = new State(new int[]{69,94});
    states[94] = new State(new int[]{44,67,45,68,46,69,47,70,48,71,49,72,50,73,51,74,52,75,53,76,54,77,55,78,56,79,57,80,58,81,59,82,60,83,61,84,62,85,63,86,64,87},new int[]{-2,95});
    states[95] = new State(new int[]{4,65,6,23,7,24,8,25,9,26,10,27,11,28,12,29,13,30,14,31,15,32,16,33,17,34,18,35,19,36,20,37,21,38,22,39,23,40,24,41,25,42,26,43,27,44,28,45,29,46,30,47,31,48,32,49,33,50,34,51,35,52,36,53,37,54,38,55,39,56,40,57,41,58,42,59,43,60},new int[]{-5,96,-4,66,-3,15});
    states[96] = new State(new int[]{3,97});
    states[97] = new State(-15);
    states[98] = new State(-10);
    states[99] = new State(-11);
    states[100] = new State(new int[]{68,101});
    states[101] = new State(new int[]{3,102});
    states[102] = new State(new int[]{69,103});
    states[103] = new State(-4);

    rules[1] = new Rule(-6, new int[]{-1,2});
    rules[2] = new Rule(-1, new int[]{-7});
    rules[3] = new Rule(-7, new int[]{-8,70,-9,-10});
    rules[4] = new Rule(-8, new int[]{65,68,3,69});
    rules[5] = new Rule(-10, new int[]{71});
    rules[6] = new Rule(-9, new int[]{-11});
    rules[7] = new Rule(-9, new int[]{-11,-9});
    rules[8] = new Rule(-11, new int[]{-12});
    rules[9] = new Rule(-11, new int[]{-13});
    rules[10] = new Rule(-11, new int[]{5});
    rules[11] = new Rule(-11, new int[]{-7});
    rules[12] = new Rule(-13, new int[]{-2,-5});
    rules[13] = new Rule(-13, new int[]{-2,-5,3});
    rules[14] = new Rule(-13, new int[]{75,-2,-5,3});
    rules[15] = new Rule(-13, new int[]{75,68,3,69,-2,-5,3});
    rules[16] = new Rule(-5, new int[]{4});
    rules[17] = new Rule(-5, new int[]{-4});
    rules[18] = new Rule(-12, new int[]{4,74,-4});
    rules[19] = new Rule(-4, new int[]{-3,72,66,3,73});
    rules[20] = new Rule(-4, new int[]{-3,72,67,3,73});
    rules[21] = new Rule(-2, new int[]{44});
    rules[22] = new Rule(-2, new int[]{45});
    rules[23] = new Rule(-2, new int[]{46});
    rules[24] = new Rule(-2, new int[]{47});
    rules[25] = new Rule(-2, new int[]{48});
    rules[26] = new Rule(-2, new int[]{49});
    rules[27] = new Rule(-2, new int[]{50});
    rules[28] = new Rule(-2, new int[]{51});
    rules[29] = new Rule(-2, new int[]{52});
    rules[30] = new Rule(-2, new int[]{53});
    rules[31] = new Rule(-2, new int[]{54});
    rules[32] = new Rule(-2, new int[]{55});
    rules[33] = new Rule(-2, new int[]{56});
    rules[34] = new Rule(-2, new int[]{57});
    rules[35] = new Rule(-2, new int[]{58});
    rules[36] = new Rule(-2, new int[]{59});
    rules[37] = new Rule(-2, new int[]{60});
    rules[38] = new Rule(-2, new int[]{61});
    rules[39] = new Rule(-2, new int[]{62});
    rules[40] = new Rule(-2, new int[]{63});
    rules[41] = new Rule(-2, new int[]{64});
    rules[42] = new Rule(-3, new int[]{6});
    rules[43] = new Rule(-3, new int[]{7});
    rules[44] = new Rule(-3, new int[]{8});
    rules[45] = new Rule(-3, new int[]{9});
    rules[46] = new Rule(-3, new int[]{10});
    rules[47] = new Rule(-3, new int[]{11});
    rules[48] = new Rule(-3, new int[]{12});
    rules[49] = new Rule(-3, new int[]{13});
    rules[50] = new Rule(-3, new int[]{14});
    rules[51] = new Rule(-3, new int[]{15});
    rules[52] = new Rule(-3, new int[]{16});
    rules[53] = new Rule(-3, new int[]{17});
    rules[54] = new Rule(-3, new int[]{18});
    rules[55] = new Rule(-3, new int[]{19});
    rules[56] = new Rule(-3, new int[]{20});
    rules[57] = new Rule(-3, new int[]{21});
    rules[58] = new Rule(-3, new int[]{22});
    rules[59] = new Rule(-3, new int[]{23});
    rules[60] = new Rule(-3, new int[]{24});
    rules[61] = new Rule(-3, new int[]{25});
    rules[62] = new Rule(-3, new int[]{26});
    rules[63] = new Rule(-3, new int[]{27});
    rules[64] = new Rule(-3, new int[]{28});
    rules[65] = new Rule(-3, new int[]{29});
    rules[66] = new Rule(-3, new int[]{30});
    rules[67] = new Rule(-3, new int[]{31});
    rules[68] = new Rule(-3, new int[]{32});
    rules[69] = new Rule(-3, new int[]{33});
    rules[70] = new Rule(-3, new int[]{34});
    rules[71] = new Rule(-3, new int[]{35});
    rules[72] = new Rule(-3, new int[]{36});
    rules[73] = new Rule(-3, new int[]{37});
    rules[74] = new Rule(-3, new int[]{38});
    rules[75] = new Rule(-3, new int[]{39});
    rules[76] = new Rule(-3, new int[]{40});
    rules[77] = new Rule(-3, new int[]{41});
    rules[78] = new Rule(-3, new int[]{42});
    rules[79] = new Rule(-3, new int[]{43});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Tokens.error, (int)Tokens.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
    switch (action)
    {
      case 2: // main_expression -> window_expression
{ }
        break;
      case 3: // window_expression -> init_window_expression, LeftFBracket, tests_expression, 
              //                      close_window_expression
{ }
        break;
      case 4: // init_window_expression -> KWindow, LeftBracket, Text, RightBracket
{
					Tester.Become(ValueStack[ValueStack.Depth-2].sVal);
				}
        break;
      case 5: // close_window_expression -> RightFBracket
{
					Tester.Unbecome();
				}
        break;
      case 6: // tests_expression -> test_expression
{  }
        break;
      case 7: // tests_expression -> test_expression, tests_expression
{ }
        break;
      case 8: // test_expression -> assignment_expression
{ }
        break;
      case 9: // test_expression -> event_expression
{ }
        break;
      case 10: // test_expression -> Comment
{ }
        break;
      case 11: // test_expression -> window_expression
{ }
        break;
      case 12: // event_expression -> test_type, identificator_expression
{
					Tester.AddTest(ValueStack[ValueStack.Depth-1].sVal, ValueStack[ValueStack.Depth-2].teVal);
				}
        break;
      case 13: // event_expression -> test_type, identificator_expression, Text
{
					Tester.AddTest(ValueStack[ValueStack.Depth-2].sVal, ValueStack[ValueStack.Depth-3].teVal, ParametersParser.Parse(ValueStack[ValueStack.Depth-1].sVal));
				}
        break;
      case 14: // event_expression -> KAssert, test_type, identificator_expression, Text
{
					Tester.AddTest(ValueStack[ValueStack.Depth-2].sVal, ValueStack[ValueStack.Depth-3].teVal, ParametersParser.Parse(ValueStack[ValueStack.Depth-1].sVal));
				}
        break;
      case 15: // event_expression -> KAssert, LeftBracket, Text, RightBracket, test_type, 
               //                     identificator_expression, Text
{
					Tester.AddTest(ValueStack[ValueStack.Depth-2].sVal, ValueStack[ValueStack.Depth-3].teVal, ValueStack[ValueStack.Depth-5].sVal, ParametersParser.Parse(ValueStack[ValueStack.Depth-1].sVal));
				}
        break;
      case 16: // identificator_expression -> Identificator
{
					if(!Tester.IsIdentificatorExist(ValueStack[ValueStack.Depth-1].sVal)) 
						throw new ArgumentException(String.Format("Identificator {0} is not exist in table.", ValueStack[ValueStack.Depth-1].sVal));

					CurrentSemanticValue.sVal = ValueStack[ValueStack.Depth-1].sVal;
				}
        break;
      case 17: // identificator_expression -> control_expression
{
					string name = Convert.ToString(ValueStack[ValueStack.Depth-1].uieVal.GetHashCode(), 16);

					if(!Tester.IsIdentificatorExist(name))
						Tester.AddIdentificator(name, ValueStack[ValueStack.Depth-1].uieVal);
						
					CurrentSemanticValue.sVal = name;
				}
        break;
      case 18: // assignment_expression -> Identificator, Equil, control_expression
{
					Tester.AddIdentificator(ValueStack[ValueStack.Depth-3].sVal, ValueStack[ValueStack.Depth-1].uieVal);
				}
        break;
      case 19: // control_expression -> control_type, LeftSBracket, Kn, Text, RightSBracket
{
					CurrentSemanticValue.uieVal = new UIElement(ValueStack[ValueStack.Depth-2].sVal, null, ValueStack[ValueStack.Depth-5].ctVal);
				}
        break;
      case 20: // control_expression -> control_type, LeftSBracket, Ku, Text, RightSBracket
{
					CurrentSemanticValue.uieVal = new UIElement(null, ValueStack[ValueStack.Depth-2].sVal, ValueStack[ValueStack.Depth-5].ctVal);
				}
        break;
      case 21: // test_type -> KClick
{
					CurrentSemanticValue.teVal = ValueStack[ValueStack.Depth-1].teVal;
				}
        break;
      case 22: // test_type -> KDClick
{
					CurrentSemanticValue.teVal = ValueStack[ValueStack.Depth-1].teVal;
				}
        break;
      case 23: // test_type -> KKClick
{
					CurrentSemanticValue.teVal = ValueStack[ValueStack.Depth-1].teVal;
				}
        break;
      case 24: // test_type -> KCtrlClick
{
					CurrentSemanticValue.teVal = ValueStack[ValueStack.Depth-1].teVal;
				}
        break;
      case 25: // test_type -> KSetFocus
{
					CurrentSemanticValue.teVal = ValueStack[ValueStack.Depth-1].teVal;
				}
        break;
      case 26: // test_type -> KSetText
{
					CurrentSemanticValue.teVal = ValueStack[ValueStack.Depth-1].teVal;
				}
        break;
      case 27: // test_type -> KCheck
{
					CurrentSemanticValue.teVal = ValueStack[ValueStack.Depth-1].teVal;
				}
        break;
      case 28: // test_type -> KUncheck
{
					CurrentSemanticValue.teVal = ValueStack[ValueStack.Depth-1].teVal;
				}
        break;
      case 29: // test_type -> KCollapse
{
					CurrentSemanticValue.teVal = ValueStack[ValueStack.Depth-1].teVal;
				}
        break;
      case 30: // test_type -> KExpand
{
					CurrentSemanticValue.teVal = ValueStack[ValueStack.Depth-1].teVal;
				}
        break;
      case 31: // test_type -> KScrollTo
{
					CurrentSemanticValue.teVal = ValueStack[ValueStack.Depth-1].teVal;
				}
        break;
      case 32: // test_type -> KItem
{
					CurrentSemanticValue.teVal = ValueStack[ValueStack.Depth-1].teVal;
				}
        break;
      case 33: // test_type -> KSelectCell
{
					CurrentSemanticValue.teVal = ValueStack[ValueStack.Depth-1].teVal;
				}
        break;
      case 34: // test_type -> KSelectItem
{
					CurrentSemanticValue.teVal = ValueStack[ValueStack.Depth-1].teVal;
				}
        break;
      case 35: // test_type -> KGetText
{
					CurrentSemanticValue.teVal = ValueStack[ValueStack.Depth-1].teVal;
				}
        break;
      case 36: // test_type -> KIsToggleOn
{
					CurrentSemanticValue.teVal = ValueStack[ValueStack.Depth-1].teVal;
				}
        break;
      case 37: // test_type -> KIsExpanded
{
					CurrentSemanticValue.teVal = ValueStack[ValueStack.Depth-1].teVal;
				}
        break;
      case 38: // test_type -> KGetItem
{
					CurrentSemanticValue.teVal = ValueStack[ValueStack.Depth-1].teVal;
				}
        break;
      case 39: // test_type -> KSelectedItem
{
					CurrentSemanticValue.teVal = ValueStack[ValueStack.Depth-1].teVal;
				}
        break;
      case 40: // test_type -> KColumnCount
{
					CurrentSemanticValue.teVal = ValueStack[ValueStack.Depth-1].teVal;
				}
        break;
      case 41: // test_type -> KRowCount
{
					CurrentSemanticValue.teVal = ValueStack[ValueStack.Depth-1].teVal;
				}
        break;
      case 42: // control_type -> KButton
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 43: // control_type -> KTree
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 44: // control_type -> KTreeItem
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 45: // control_type -> KCustom
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 46: // control_type -> KGroup
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 47: // control_type -> KThumb
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 48: // control_type -> KDataGrid
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 49: // control_type -> KDataItem
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 50: // control_type -> KToolTip
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 51: // control_type -> KDocument
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 52: // control_type -> KPane
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 53: // control_type -> KHeader
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 54: // control_type -> KHeaderItem
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 55: // control_type -> KTable
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 56: // control_type -> KTitleBar
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 57: // control_type -> KSeparator
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 58: // control_type -> KSplitButton
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 59: // control_type -> KText
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 60: // control_type -> KToolBar
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 61: // control_type -> KTab
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 62: // control_type -> KCalendar
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 63: // control_type -> KCheckBox
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 64: // control_type -> KComboBox
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 65: // control_type -> KEdit
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 66: // control_type -> KHyperlink
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 67: // control_type -> KImage
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 68: // control_type -> KListItem
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 69: // control_type -> KTabItem
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 70: // control_type -> KMenu
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 71: // control_type -> KList
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 72: // control_type -> KMenuItem
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 73: // control_type -> KProgressBar
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 74: // control_type -> KRadioButton
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 75: // control_type -> KScrollBar
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 76: // control_type -> KSlider
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 77: // control_type -> KSpinner
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 78: // control_type -> KStatusBar
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
      case 79: // control_type -> KMenuBar
{
					CurrentSemanticValue.ctVal = ValueStack[ValueStack.Depth-1].ctVal;
				}
        break;
    }
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliasses != null && aliasses.ContainsKey(terminal))
        return aliasses[terminal];
    else if (((Tokens)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Tokens)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

}
}
