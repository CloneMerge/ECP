﻿/*
==============================================================================
Copyright © Jason Drawdy 

All rights reserved.

The MIT License (MIT)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.

Except as contained in this notice, the name of the above copyright holder
shall not be used in advertising or otherwise to promote the sale, use or
other dealings in this Software without prior written authorization.
==============================================================================
*/

#region Imports

using System.Threading;

#endregion
namespace ECP
{
    /// <summary>
    /// A manageable thread which has multiple identifiers.
    /// </summary>
    public class ECPThread
    {
        #region Variables
        
        /// <summary>
        /// The identifying name for the thread.
        /// </summary>
        public string ThreadName { get; private set; }
        /// <summary>
        /// An identifier for the thread similar to a GUID.
        /// </summary>
        public string ThreadID { get; private set; }
        /// <summary>
        /// The method that has been encapsulated within a thread.
        /// </summary>
        public Thread Method { get; private set; }

        #endregion
        #region Initialization

        /// <summary>
        /// A manageable thread.
        /// </summary>
        /// <param name="name">The name of the thread.</param>
        /// <param name="id">The ID for the thread.</param>
        /// <param name="thread">The thread to encapsulate.</param>
        public ECPThread(string name, string id, Thread thread)
        {
            ThreadName = name;
            ThreadID = id;
            Method = thread;
        }

        #endregion
    }
}
