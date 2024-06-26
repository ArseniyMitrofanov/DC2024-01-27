﻿using Publisher.Entity.Db;
using Publisher.Entity.DTO.RequestTO;
using Publisher.Entity.DTO.ResponseTO;
using Publisher.Service.Interface.Common;

namespace Publisher.Service.Interface
{
    public interface IstickerService : ICrudService<sticker, stickerRequestTO, stickerResponseTO>
    {
        Task<IList<stickerResponseTO>> GetBystoryID(int storyId);
    }
}
