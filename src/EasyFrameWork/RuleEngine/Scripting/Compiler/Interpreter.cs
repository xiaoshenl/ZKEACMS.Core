/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.RuleEngine.Scripting.Ast;
using System;
using System.Collections.Generic;

namespace Easy.RuleEngine.Scripting.Compiler
{
    public class Interpreter
    {
        public EvaluationResult Evalutate(EvaluationContext context)
        {
            return new InterpreterVisitor(context).Evaluate();
        }
    }

    public class EvaluationContext
    {
        public AbstractSyntaxTree Tree { get; set; }
        public Func<string, IList<object>, object> MethodInvocationCallback { get; set; }
    }
}