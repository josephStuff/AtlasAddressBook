﻿using AtlasAddressBook.Services.Interfaces;

namespace AtlasAddressBook.Services
{
    public class ImageService : IImageService
    {
        #region Globals
        private readonly string[] suffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB" };

        #endregion

        #region Convert Byte Array to File
        public string ConvertByteArrayToFile(byte[] fileData, string extension)
        {
            try
            {
                string imageBase64Data = Convert.ToBase64String(fileData);
                return string.Format($"data:{extension};base64,{imageBase64Data}");
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region Convert File to Byte Array
        public async Task<byte[]> ConvertFileToByteArrayAsync(IFormFile file)
        {
            try
            {
                using MemoryStream memoryStream = new();
                await file.CopyToAsync(memoryStream);
                byte[] byteFile = memoryStream.ToArray();

                return byteFile;
            }
            catch (Exception)
            {
                throw;
            }
        }



        #endregion
    }
}
