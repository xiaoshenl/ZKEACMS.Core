/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.RuleEngine.Scripting.Ast;
using System.Collections.Generic;

namespace Easy.RuleEngine.Scripting
{
    public class ScriptExpressionResult
    {
        public AbstractSyntaxTree Tree { get; set; }
        public List<ErrorAstNode> Errors { get; set; }
    }
}
