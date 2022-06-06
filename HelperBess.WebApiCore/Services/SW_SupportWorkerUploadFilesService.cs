﻿using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SW_SupportWorkerUploadFilesService: ISW_SupportWorkerUploadFiles
    {
        HelperBeesContext dbContext;
        public SW_SupportWorkerUploadFilesService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SW_SupportWorkerUploadFiles AddSW_SupportWorkerUploadFiles(SW_SupportWorkerUploadFiles SW_SupportWorkerUploadFiles)
        {
            if (SW_SupportWorkerUploadFiles != null)
            {
                dbContext.SW_SupportWorkerUploadFiles.Add(SW_SupportWorkerUploadFiles);
                dbContext.SaveChanges();
                return SW_SupportWorkerUploadFiles;
            }

            return null;
        }

        public SW_SupportWorkerUploadFiles DeleteSW_SupportWorkerUploadFiles(int id)
        {
            var SW_SupportWorkerUploadFiles = dbContext.SW_SupportWorkerUploadFiles.FirstOrDefault(x => x.SupportWorkerId == id);
            dbContext.Entry(SW_SupportWorkerUploadFiles).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SW_SupportWorkerUploadFiles;
        }

        public IEnumerable<SW_SupportWorkerUploadFiles> GetSW_SupportWorkerUploadFiles()
        {
            var SW_SupportWorkerUploadFiles = dbContext.SW_SupportWorkerUploadFiles.ToList();
            return SW_SupportWorkerUploadFiles;
        }

        public SW_SupportWorkerUploadFiles GetSW_SupportWorkerUploadFilesById(int id)
        {
            var SW_SupportWorkerUploadFiles = dbContext.SW_SupportWorkerUploadFiles.FirstOrDefault(x => x.SupportWorkerId == id);
            return SW_SupportWorkerUploadFiles;
        }

        public SW_SupportWorkerUploadFiles UpdateSW_SupportWorkerUploadFiles(SW_SupportWorkerUploadFiles SW_SupportWorkerUploadFiles)
        {
            dbContext.Entry(SW_SupportWorkerUploadFiles).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SW_SupportWorkerUploadFiles;
        }
    }
}
