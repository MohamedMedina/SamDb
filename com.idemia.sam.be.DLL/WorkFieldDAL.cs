using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationBlocks.Layers;
using Business;
using com.idemia.sam.be.Contracts;
using com.idemia.sam.be.Helpers;
using Common;

namespace com.idemia.sam.be.DAL
{
    public class WorkFieldDAL : IWorkFieldDAL
    {
 
        public ICollection<WorkFieldDTO> GetAllWorkFieldFromDB()
        {
            ICollection<WorkFieldDTO> outputList = default(ICollection<WorkFieldDTO>);

            try
            {
                // 1- Select All work fields From DB
                WorkFieldBusiness _WorkFieldBusiness = new WorkFieldBusiness();
                WorkFieldList _WorkFieldList = _WorkFieldBusiness.SelectRows(null, null, null);

                if (_WorkFieldList != null && _WorkFieldList.Count > 0)

                {
                    // 2- Prepare Mapping Objects (Fill Values from DB)
                    Mapper._WorkFieldList = fillWorkFieldList(); 


                    // 3- Perform Mapping to Output
                    outputList = Mapper.MapWorkFieldAsOutput();
                }
            }
            catch (Exception ex)
            {
                // Log Exception Here
                throw; //new Exception(ex.Message);
            }

            return outputList;
        }
        public WorkFieldDTO GetWorkFieldFromDB(int id)
        {
            {
                ICollection<WorkFieldDTO> outputList = default(ICollection<WorkFieldDTO>);
                WorkFieldDTO output = new WorkFieldDTO();

                try
                {
                    WorkFieldBusiness _WorkFieldBusiness = new WorkFieldBusiness();
                    WorkFieldList _WorkFieldList = _WorkFieldBusiness.SelectRows(id, null, null);

                    if (_WorkFieldList != null && _WorkFieldList.Count > 0)
                    //outputList = Mapper.MapUserAsOutput();
                    {
                        // 2- Prepare Mapping Objects (Fill Values from DB)
                        Mapper._WorkFieldList = _WorkFieldList;

                        // 3- Perform Mapping to Output
                        outputList = Mapper.MapWorkFieldAsOutput();

                        if (outputList != null && outputList.Count > 0)
                            output = outputList.FirstOrDefault();
                    }
                }
                catch (Exception ex)
                {
                    // Log Exception Here
                    throw; //new Exception(ex.Message);
                }

                return output;

            }


        }
        WorkFieldDTO IWorkFieldDAL.AddWorkFieldToDB(WorkFieldDTO workFieldDTO)
        {
            BaseDataAccess _db = new BaseDataAccess();
            using (DbTransaction dbTransaction = _db.CreateTransaction())
            {
                try
                {
                    // 1- Perform Mapping to  Input (for Saving in DB)
                    if (Mapper.MapWorkFieldAsInput(workFieldDTO))
                    {

                        // 2- Insert WorkField  in DB
                        WorkFieldBusiness workFieldBusiness = new WorkFieldBusiness();
                        if (workFieldBusiness.InsertRow(dbTransaction, Mapper._WorkField) > 0)
                        {
                            dbTransaction.Commit();
                            workFieldDTO.Id = Mapper._WorkField.Id;
                        }

                        else
                        {
                            dbTransaction.Rollback();
                            throw new DataException("DataBase Operation Failure");
                        }
                    }
                    else
                        throw new ArgumentNullException("workFieldDTO");
                }
                catch (Exception ex)
                {
                    dbTransaction.Rollback();
                    throw;
                }
            }

            return workFieldDTO;
        }
        public WorkFieldDTO UpdateWorkFieldInDB(WorkFieldDTO workFieldDTO)
        {
            BaseDataAccess _db = new BaseDataAccess();
            using (DbTransaction dbTransaction = _db.CreateTransaction())
            {
                try

                {
                    // 1- Perform Mapping to  Input (for Saving in DB)
                    if (Mapper.MapWorkFieldAsInput(workFieldDTO))
                    {
                        // 2- Select WorkField to be updated
                        WorkFieldBusiness workFieldBusiness = new WorkFieldBusiness();
                        WorkFieldList workFieldList = workFieldBusiness.SelectRows(Mapper._WorkField.Id, null, null);

                        if (workFieldList != null && workFieldList.Count > 0)
                        {
                            workFieldList[0].Id   = Mapper._WorkField.Id;
                            workFieldList[0].name = Mapper._WorkField.name;
                            workFieldList[0].nameAr = Mapper._WorkField.nameAr;


                            // 3- Update WorkField Data by Input Values
                            workFieldBusiness = new WorkFieldBusiness();
                            if (workFieldBusiness.UpdateRow(dbTransaction, workFieldList[0]) > 0)
                                dbTransaction.Commit();

                            else
                            {
                                dbTransaction.Rollback();
                                throw new Exception("DataBase Operation Failure");
                            }
                        }
                        else
                        {
                            dbTransaction.Rollback();
                            throw new Exception("WorkField Id Not Found in DB");
                        }
                    }
                    else
                        throw new ArgumentNullException("workFieldDTO");
                }
                catch (Exception ex)
                {
                    dbTransaction.Rollback();
                    throw;
                }
            }

            return workFieldDTO;
        }
        public bool DeleteWorkFieldFromDB(int id)
        {
            bool result = default(bool);

            BaseDataAccess _db = new BaseDataAccess();
            using (DbTransaction dbTransaction = _db.CreateTransaction())
            {
                try
                {
                    // 1- Select WorkField From DB by ID
                    WorkFieldBusiness workFieldBusiness = new WorkFieldBusiness();
                    WorkFieldList workFieldList = workFieldBusiness.SelectRows(id, null, null);

                    if (workFieldList != null && workFieldList.Count > 0)
                    {
                        foreach (WorkField workField in workFieldList)
                        {
                            workFieldBusiness = new WorkFieldBusiness();
                            workFieldBusiness.DeleteRow(dbTransaction, workField);
                        }

                        dbTransaction.Commit();
                        result = true;
                    }

                    else
                    {
                        dbTransaction.Rollback();
                        throw new Exception("WorkField Id Not Found in DB");
                    }
                }
                catch (Exception)
                {
                    dbTransaction.Rollback();
                    throw new Exception("DataBase Operation Failure");
                }
            }

            return result;
        }
        private List<WorkField> fillWorkFieldList()
        {
            WorkFieldBusiness _WorkFieldBusiness = new WorkFieldBusiness();
            WorkFieldList _WorkFieldList = _WorkFieldBusiness.SelectRows(null, null, null);
            return _WorkFieldList;
        }
    }
    }

