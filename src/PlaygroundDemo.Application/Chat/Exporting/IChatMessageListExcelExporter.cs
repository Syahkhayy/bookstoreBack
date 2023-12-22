using System.Collections.Generic;
using Abp;
using PlaygroundDemo.Chat.Dto;
using PlaygroundDemo.Dto;

namespace PlaygroundDemo.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
