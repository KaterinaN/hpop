using System;
using System.Collections.Generic;
using System.Text;

namespace OpenPop.Mime.Traverse
{
    /// <summary>
    /// Finds all <see cref="MessagePart"/>s which are considered to be attachments and are not considered to be inline images
    /// </summary>
    internal class AttachmentWithoutInlineImageFinder : MultipleMessagePartFinder
    {
        protected override List<MessagePart> CaseLeaf(MessagePart messagePart)
        {
            if (messagePart == null)
                throw new ArgumentNullException("messagePart");

            // Maximum space needed is one
            List<MessagePart> leafAnswer = new List<MessagePart>(1);

            if (messagePart.IsAttachment && !messagePart.IsInlineImage)
                leafAnswer.Add(messagePart);

            return leafAnswer;
        }
    }
}
