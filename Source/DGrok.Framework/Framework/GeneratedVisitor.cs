// DGrok Delphi parser
// Copyright (C) 2007 Joe White
// http://www.excastle.com/dgrok
//
// Licensed under the Open Software License version 3.0
// http://www.opensource.org/licenses/osl-3.0.php

// Autogenerated file - do not edit

using System;
using System.Collections.Generic;
using System.Text;
using DGrok.DelphiNodes;

namespace DGrok.Framework
{
    public partial class Visitor
    {
        public virtual void VisitArrayTypeNode(ArrayTypeNode node)
        {
            Visit(node.Array);
            Visit(node.OpenBracket);
            Visit(node.IndexList);
            Visit(node.CloseBracket);
            Visit(node.Of);
            Visit(node.Type);
        }
        public virtual void VisitAssemblerStatementNode(AssemblerStatementNode node)
        {
            Visit(node.Asm);
            Visit(node.End);
        }
        public virtual void VisitAttributeNode(AttributeNode node)
        {
            Visit(node.OpenBracket);
            Visit(node.Scope);
            Visit(node.Colon);
            Visit(node.Value);
            Visit(node.CloseBracket);
        }
        public virtual void VisitBinaryOperationNode(BinaryOperationNode node)
        {
            Visit(node.Left);
            Visit(node.Operator);
            Visit(node.Right);
        }
        public virtual void VisitBlockNode(BlockNode node)
        {
            Visit(node.Begin);
            Visit(node.StatementList);
            Visit(node.End);
        }
        public virtual void VisitCaseSelectorNode(CaseSelectorNode node)
        {
            Visit(node.Values);
            Visit(node.Colon);
            Visit(node.Statement);
            Visit(node.Semicolon);
        }
        public virtual void VisitCaseStatementNode(CaseStatementNode node)
        {
            Visit(node.Case);
            Visit(node.Expression);
            Visit(node.Of);
            Visit(node.SelectorList);
            Visit(node.Else);
            Visit(node.ElseStatements);
            Visit(node.End);
        }
        public virtual void VisitClassOfNode(ClassOfNode node)
        {
            Visit(node.Class);
            Visit(node.Of);
            Visit(node.Type);
        }
        public virtual void VisitClassTypeNode(ClassTypeNode node)
        {
            Visit(node.Class);
            Visit(node.Disposition);
            Visit(node.OpenParenthesis);
            Visit(node.InheritanceList);
            Visit(node.CloseParenthesis);
            Visit(node.Contents);
            Visit(node.End);
        }
        public virtual void VisitConstantDeclNode(ConstantDeclNode node)
        {
            Visit(node.Name);
            Visit(node.Colon);
            Visit(node.Type);
            Visit(node.EqualSign);
            Visit(node.Value);
            Visit(node.PortabilityDirectiveList);
            Visit(node.Semicolon);
        }
        public virtual void VisitConstantListNode(ConstantListNode node)
        {
            Visit(node.OpenParenthesis);
            Visit(node.ItemList);
            Visit(node.CloseParenthesis);
        }
        public virtual void VisitConstSectionNode(ConstSectionNode node)
        {
            Visit(node.Const);
            Visit(node.ConstList);
        }
        public virtual void VisitDirectiveNode(DirectiveNode node)
        {
            Visit(node.Semicolon);
            Visit(node.Directive);
            Visit(node.Value);
            Visit(node.Data);
        }
        public virtual void VisitEnumeratedTypeElementNode(EnumeratedTypeElementNode node)
        {
            Visit(node.Name);
            Visit(node.EqualSign);
            Visit(node.Value);
        }
        public virtual void VisitEnumeratedTypeNode(EnumeratedTypeNode node)
        {
            Visit(node.OpenParenthesis);
            Visit(node.ItemList);
            Visit(node.CloseParenthesis);
        }
        public virtual void VisitExceptionItemNode(ExceptionItemNode node)
        {
            Visit(node.On);
            Visit(node.Name);
            Visit(node.Colon);
            Visit(node.Type);
            Visit(node.Do);
            Visit(node.Statement);
            Visit(node.Semicolon);
        }
        public virtual void VisitExportsItemNode(ExportsItemNode node)
        {
            Visit(node.Name);
            Visit(node.SpecifierList);
        }
        public virtual void VisitExportsSpecifierNode(ExportsSpecifierNode node)
        {
            Visit(node.Keyword);
            Visit(node.Value);
        }
        public virtual void VisitExportsStatementNode(ExportsStatementNode node)
        {
            Visit(node.Exports);
            Visit(node.ItemList);
            Visit(node.Semicolon);
        }
        public virtual void VisitFancyBlockNode(FancyBlockNode node)
        {
            Visit(node.DeclList);
            Visit(node.Block);
        }
        public virtual void VisitFieldDeclNode(FieldDeclNode node)
        {
            Visit(node.NameList);
            Visit(node.Colon);
            Visit(node.Type);
            Visit(node.PortabilityDirectiveList);
            Visit(node.Semicolon);
        }
        public virtual void VisitFieldSectionNode(FieldSectionNode node)
        {
            Visit(node.Class);
            Visit(node.Var);
            Visit(node.FieldList);
        }
        public virtual void VisitFileTypeNode(FileTypeNode node)
        {
            Visit(node.File);
            Visit(node.Of);
            Visit(node.Type);
        }
        public virtual void VisitForInStatementNode(ForInStatementNode node)
        {
            Visit(node.For);
            Visit(node.LoopVariable);
            Visit(node.In);
            Visit(node.Expression);
            Visit(node.Do);
            Visit(node.Statement);
        }
        public virtual void VisitForStatementNode(ForStatementNode node)
        {
            Visit(node.For);
            Visit(node.LoopVariable);
            Visit(node.ColonEquals);
            Visit(node.StartingValue);
            Visit(node.Direction);
            Visit(node.EndingValue);
            Visit(node.Do);
            Visit(node.Statement);
        }
        public virtual void VisitGotoStatementNode(GotoStatementNode node)
        {
            Visit(node.Goto);
            Visit(node.LabelId);
        }
        public virtual void VisitIfStatementNode(IfStatementNode node)
        {
            Visit(node.If);
            Visit(node.Condition);
            Visit(node.Then);
            Visit(node.ThenStatement);
            Visit(node.Else);
            Visit(node.ElseStatement);
        }
        public virtual void VisitInitSectionNode(InitSectionNode node)
        {
            Visit(node.InitializationHeader);
            Visit(node.InitializationStatements);
            Visit(node.FinalizationHeader);
            Visit(node.FinalizationStatements);
            Visit(node.End);
        }
        public virtual void VisitInterfaceTypeNode(InterfaceTypeNode node)
        {
            Visit(node.Interface);
            Visit(node.OpenParenthesis);
            Visit(node.BaseInterface);
            Visit(node.CloseParenthesis);
            Visit(node.OpenBracket);
            Visit(node.Guid);
            Visit(node.CloseBracket);
            Visit(node.MethodAndPropertyList);
            Visit(node.End);
        }
        public virtual void VisitLabelDeclSectionNode(LabelDeclSectionNode node)
        {
            Visit(node.Label);
            Visit(node.LabelList);
            Visit(node.Semicolon);
        }
        public virtual void VisitLabeledStatementNode(LabeledStatementNode node)
        {
            Visit(node.Label);
            Visit(node.Colon);
            Visit(node.Statement);
        }
        public virtual void VisitMethodHeadingNode(MethodHeadingNode node)
        {
            Visit(node.Class);
            Visit(node.MethodType);
            Visit(node.Name);
            Visit(node.OpenParenthesis);
            Visit(node.ParameterList);
            Visit(node.CloseParenthesis);
            Visit(node.Colon);
            Visit(node.ReturnType);
            Visit(node.DirectiveList);
            Visit(node.Semicolon);
        }
        public virtual void VisitMethodImplementationNode(MethodImplementationNode node)
        {
            Visit(node.MethodHeading);
            Visit(node.FancyBlock);
            Visit(node.Semicolon);
        }
        public virtual void VisitMethodResolutionNode(MethodResolutionNode node)
        {
            Visit(node.MethodType);
            Visit(node.InterfaceMethod);
            Visit(node.EqualSign);
            Visit(node.ImplementationMethod);
            Visit(node.Semicolon);
        }
        public virtual void VisitNumberFormatNode(NumberFormatNode node)
        {
            Visit(node.Value);
            Visit(node.SizeColon);
            Visit(node.Size);
            Visit(node.PrecisionColon);
            Visit(node.Precision);
        }
        public virtual void VisitOpenArrayNode(OpenArrayNode node)
        {
            Visit(node.Array);
            Visit(node.Of);
            Visit(node.Type);
        }
        public virtual void VisitPackageNode(PackageNode node)
        {
            Visit(node.Package);
            Visit(node.Name);
            Visit(node.Semicolon);
            Visit(node.RequiresClause);
            Visit(node.ContainsClause);
            Visit(node.AttributeList);
            Visit(node.End);
            Visit(node.Dot);
        }
        public virtual void VisitPackedTypeNode(PackedTypeNode node)
        {
            Visit(node.Packed);
            Visit(node.Type);
        }
        public virtual void VisitParameterizedNode(ParameterizedNode node)
        {
            Visit(node.Left);
            Visit(node.OpenDelimiter);
            Visit(node.ParameterList);
            Visit(node.CloseDelimiter);
        }
        public virtual void VisitParameterNode(ParameterNode node)
        {
            Visit(node.Modifier);
            Visit(node.Names);
            Visit(node.Colon);
            Visit(node.Type);
            Visit(node.EqualSign);
            Visit(node.DefaultValue);
        }
        public virtual void VisitParenthesizedExpressionNode(ParenthesizedExpressionNode node)
        {
            Visit(node.OpenParenthesis);
            Visit(node.Expression);
            Visit(node.CloseParenthesis);
        }
        public virtual void VisitPointerDereferenceNode(PointerDereferenceNode node)
        {
            Visit(node.Operand);
            Visit(node.Caret);
        }
        public virtual void VisitPointerTypeNode(PointerTypeNode node)
        {
            Visit(node.Caret);
            Visit(node.Type);
        }
        public virtual void VisitProcedureTypeNode(ProcedureTypeNode node)
        {
            Visit(node.MethodType);
            Visit(node.OpenParenthesis);
            Visit(node.ParameterList);
            Visit(node.CloseParenthesis);
            Visit(node.Colon);
            Visit(node.ReturnType);
            Visit(node.FirstDirectives);
            Visit(node.Of);
            Visit(node.Object);
            Visit(node.SecondDirectives);
        }
        public virtual void VisitProgramNode(ProgramNode node)
        {
            Visit(node.Program);
            Visit(node.Name);
            Visit(node.NoiseOpenParenthesis);
            Visit(node.NoiseContents);
            Visit(node.NoiseCloseParenthesis);
            Visit(node.Semicolon);
            Visit(node.UsesClause);
            Visit(node.DeclarationList);
            Visit(node.InitSection);
            Visit(node.Dot);
        }
        public virtual void VisitPropertyNode(PropertyNode node)
        {
            Visit(node.Class);
            Visit(node.Property);
            Visit(node.Name);
            Visit(node.OpenBracket);
            Visit(node.ParameterList);
            Visit(node.CloseBracket);
            Visit(node.Colon);
            Visit(node.Type);
            Visit(node.DirectiveList);
            Visit(node.Semicolon);
        }
        public virtual void VisitRaiseStatementNode(RaiseStatementNode node)
        {
            Visit(node.Raise);
            Visit(node.Exception);
            Visit(node.At);
            Visit(node.Address);
        }
        public virtual void VisitRecordFieldConstantNode(RecordFieldConstantNode node)
        {
            Visit(node.Name);
            Visit(node.Colon);
            Visit(node.Value);
        }
        public virtual void VisitRecordTypeNode(RecordTypeNode node)
        {
            Visit(node.Record);
            Visit(node.Contents);
            Visit(node.VariantSection);
            Visit(node.End);
        }
        public virtual void VisitRepeatStatementNode(RepeatStatementNode node)
        {
            Visit(node.Repeat);
            Visit(node.StatementList);
            Visit(node.Until);
            Visit(node.Condition);
        }
        public virtual void VisitRequiresClauseNode(RequiresClauseNode node)
        {
            Visit(node.Requires);
            Visit(node.PackageList);
            Visit(node.Semicolon);
        }
        public virtual void VisitSetLiteralNode(SetLiteralNode node)
        {
            Visit(node.OpenBracket);
            Visit(node.ItemList);
            Visit(node.CloseBracket);
        }
        public virtual void VisitSetOfNode(SetOfNode node)
        {
            Visit(node.Set);
            Visit(node.Of);
            Visit(node.Type);
        }
        public virtual void VisitStringOfLengthNode(StringOfLengthNode node)
        {
            Visit(node.String);
            Visit(node.OpenBracket);
            Visit(node.Length);
            Visit(node.CloseBracket);
        }
        public virtual void VisitTryExceptNode(TryExceptNode node)
        {
            Visit(node.Try);
            Visit(node.TryStatements);
            Visit(node.Except);
            Visit(node.ExceptionItemList);
            Visit(node.Else);
            Visit(node.ElseStatements);
            Visit(node.End);
        }
        public virtual void VisitTryFinallyNode(TryFinallyNode node)
        {
            Visit(node.Try);
            Visit(node.TryStatements);
            Visit(node.Finally);
            Visit(node.FinallyStatements);
            Visit(node.End);
        }
        public virtual void VisitTypeDeclNode(TypeDeclNode node)
        {
            Visit(node.Name);
            Visit(node.EqualSign);
            Visit(node.TypeKeyword);
            Visit(node.Type);
            Visit(node.PortabilityDirectiveList);
            Visit(node.Semicolon);
        }
        public virtual void VisitTypeForwardDeclarationNode(TypeForwardDeclarationNode node)
        {
            Visit(node.Name);
            Visit(node.EqualSign);
            Visit(node.Type);
            Visit(node.Semicolon);
        }
        public virtual void VisitTypeHelperNode(TypeHelperNode node)
        {
            Visit(node.TypeKeyword);
            Visit(node.Helper);
            Visit(node.OpenParenthesis);
            Visit(node.BaseHelperType);
            Visit(node.CloseParenthesis);
            Visit(node.For);
            Visit(node.Type);
            Visit(node.Contents);
            Visit(node.End);
        }
        public virtual void VisitTypeSectionNode(TypeSectionNode node)
        {
            Visit(node.Type);
            Visit(node.TypeList);
        }
        public virtual void VisitUnaryOperationNode(UnaryOperationNode node)
        {
            Visit(node.Operator);
            Visit(node.Operand);
        }
        public virtual void VisitUnitNode(UnitNode node)
        {
            Visit(node.Unit);
            Visit(node.UnitName);
            Visit(node.PortabilityDirectives);
            Visit(node.Semicolon);
            Visit(node.InterfaceSection);
            Visit(node.ImplementationSection);
            Visit(node.InitSection);
            Visit(node.Dot);
        }
        public virtual void VisitUnitSectionNode(UnitSectionNode node)
        {
            Visit(node.HeaderKeyword);
            Visit(node.UsesClause);
            Visit(node.Contents);
        }
        public virtual void VisitUsedUnitNode(UsedUnitNode node)
        {
            Visit(node.Name);
            Visit(node.In);
            Visit(node.FileName);
        }
        public virtual void VisitUsesClauseNode(UsesClauseNode node)
        {
            Visit(node.Uses);
            Visit(node.UnitList);
            Visit(node.Semicolon);
        }
        public virtual void VisitVarDeclNode(VarDeclNode node)
        {
            Visit(node.Names);
            Visit(node.Colon);
            Visit(node.Type);
            Visit(node.FirstPortabilityDirectives);
            Visit(node.Absolute);
            Visit(node.AbsoluteAddress);
            Visit(node.EqualSign);
            Visit(node.Value);
            Visit(node.SecondPortabilityDirectives);
            Visit(node.Semicolon);
        }
        public virtual void VisitVariantGroupNode(VariantGroupNode node)
        {
            Visit(node.ValueList);
            Visit(node.Colon);
            Visit(node.OpenParenthesis);
            Visit(node.FieldDeclList);
            Visit(node.VariantSection);
            Visit(node.CloseParenthesis);
            Visit(node.Semicolon);
        }
        public virtual void VisitVariantSectionNode(VariantSectionNode node)
        {
            Visit(node.Case);
            Visit(node.Name);
            Visit(node.Colon);
            Visit(node.Type);
            Visit(node.Of);
            Visit(node.VariantGroupList);
        }
        public virtual void VisitVarSectionNode(VarSectionNode node)
        {
            Visit(node.Var);
            Visit(node.VarList);
        }
        public virtual void VisitVisibilityNode(VisibilityNode node)
        {
            Visit(node.Strict);
            Visit(node.Visibility);
        }
        public virtual void VisitVisibilitySectionNode(VisibilitySectionNode node)
        {
            Visit(node.Visibility);
            Visit(node.Contents);
        }
        public virtual void VisitWhileStatementNode(WhileStatementNode node)
        {
            Visit(node.While);
            Visit(node.Condition);
            Visit(node.Do);
            Visit(node.Statement);
        }
        public virtual void VisitWithStatementNode(WithStatementNode node)
        {
            Visit(node.With);
            Visit(node.ExpressionList);
            Visit(node.Do);
            Visit(node.Statement);
        }
    }
}
