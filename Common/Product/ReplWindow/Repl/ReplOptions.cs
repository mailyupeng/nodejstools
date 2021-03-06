﻿//*********************************************************//
//    Copyright (c) Microsoft. All rights reserved.
//    
//    Apache 2.0 License
//    
//    You may obtain a copy of the License at
//    http://www.apache.org/licenses/LICENSE-2.0
//    
//    Unless required by applicable law or agreed to in writing, software 
//    distributed under the License is distributed on an "AS IS" BASIS, 
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or 
//    implied. See the License for the specific language governing 
//    permissions and limitations under the License.
//
//*********************************************************//


#if NTVS_FEATURE_INTERACTIVEWINDOW
namespace Microsoft.NodejsTools.Repl {
#else
namespace Microsoft.VisualStudio.Repl {
#endif
    /// <summary>
    /// Enumerates the various options that can be configured for a REPL window.
    /// </summary>
    public enum ReplOptions {
        /// <summary>
        /// True/false, true if output should be echoed into the buffer.
        /// </summary>
        ShowOutput,
        /// <summary>
        /// True/false, true if up/down arrow should cycle through history, false if the seperate commands
        /// (bound to Alt-P/Alt-N by default) should be the only way to cycle through history.
        /// </summary>
        UseSmartUpDown,
        /// <summary>
        /// String, the prompt to be displayed for input.  Defaults to "» "
        /// </summary>
        PrimaryPrompt,
        /// <summary>
        /// String, the secondary prompt to be displayed when an input spans more than one line.
        /// 
        /// Defaults to empty string - no secondary prompt is enabled.
        /// </summary>
        SecondaryPrompt,
        /// <summary>
        /// String, the prompt to be used when we are requesting input from the user.
        /// 
        /// Defaults to the empty string - no input prompt is displayed, just a blank line.
        /// </summary>
        StandardInputPrompt,
        /// <summary>
        /// String, the prefix that should be used for meta commands.  Defaults to "%"
        /// </summary>
        CommandPrefix,
        /// <summary>
        /// True/false, true if the prompts should be displayed in a seperate margin.  Defaults to false.
        /// </summary>
        DisplayPromptInMargin,
        /// <summary>
        /// True/false, true if ANSI color codes should be interpreted and color should be displayed, false if
        /// escape characters should just be outputted uninterpretted.  Defaults to false.
        /// </summary>
        SupportAnsiColors,

        /// <summary>
        /// True/false, true if prompts can include formatting directives.  Supported escape codes are:
        ///     \#  - Insert the current input # into the prompt string
        ///     \\  - Insert a backslash into the prompt string
        ///     \D  - Insert the date into the prompt string
        ///     \T  - Insert the time into the prompt string
        /// </summary>
        FormattedPrompts,

        /// <summary>
        /// String, the prompt to be displayed for input.  Defaults to "» "
        /// 
        /// When setting using the Current prompt the previous prompts in the buffer are not changed.
        /// If there is a current input executing then the next prompt will reflect the value set.
        /// Otherwise only the currently active input prompt will be updated.
        /// </summary>
        CurrentPrimaryPrompt,
        /// <summary>
        /// String, the secondary prompt to be displayed when an input spans more than one line.
        /// 
        /// Defaults to empty string - no secondary prompt is enabled.
        /// 
        /// When setting using the Current option the previous prompts in the buffer are not changed.
        /// If there is a current input executing then the next prompt will reflect the value set.
        /// Otherwise only the currently active input prompt will be updated.
        /// </summary>
        CurrentSecondaryPrompt,
    }
}
