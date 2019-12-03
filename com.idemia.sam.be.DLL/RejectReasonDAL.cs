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
    public class RejectReasonDAL : IRejectReasonDAL
    {
       
        public ICollection<RejectReasonDTO> GetAllRejectReasonFromDB()
        {
            ICollection<RejectReasonDTO> outputList = default(ICollection<RejectReasonDTO>);

            try
            {
                // 1- Select All Rejection Reasons From DB
                RejectReasonBusiness _RejectReasonBusiness = new RejectReasonBusiness();
                RejectReasonList _RejectReasonList = _RejectReasonBusiness.SelectRows(null, null, null);

                if (_RejectReasonList != null && _RejectReasonList.Count > 0)

                {
                    // 2- Prepare Mapping Objects (Fill Values from DB)
                    Mapper._RejectReasonList = fillRejectReasonList(); //default(List<Rejection Reason>);


                    // 3- Perform Mapping to Output
                    outputList = Mapper.MapRejectReasonAsOutput();
                }
            }
            catch (Exception ex)
            {
                // Log Exception Here
                throw; //new Exception(ex.Message);
            }

            return outputList;
        }
        public RejectReasonDTO GetRejectReasonByIDFromDB(int id)
        {
            {
                ICollection<RejectReasonDTO> outputList = default(ICollection<RejectReasonDTO>);
                RejectReasonDTO output = new RejectReasonDTO();

                try
                {
                    RejectReasonBusiness _RejectReasonBusiness = new RejectReasonBusiness();
                    RejectReasonList _RejectReasonList = _RejectReasonBusiness.SelectRows(id, null, null);

                    if (_RejectReasonList != null && _RejectReasonList.Count > 0)
                    //outputList = Mapper.MapUserAsOutput();
                    {
                        // 2- Prepare Mapping Objects (Fill Values from DB)
                        Mapper._RejectReasonList = _RejectReasonList;


                        // 3- Perform Mapping to Output
                        outputList = Mapper.MapRejectReasonAsOutput();

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
        public RejectReasonDTO AddRejectReasonToDB(RejectReasonDTO rejectReasonDTO)
        {

            BaseDataAccess _db = new BaseDataAccess();
            using (DbTransaction dbTransaction = _db.CreateTransaction())
            {
                try
                {
                    // 1- Perform Mapping to  Input (for Saving in DB)
                    if (Mapper.MapRejectReasonAsInput(rejectReasonDTO))
                    {
                        ////User user = Mapper._User;
                        ////List<UserGroup> userGroups = Mapper._UserGroupListInput;
                        //Mapper._User.createDate = DateTime.Now;

                        // 2- Insert RejectReason  in DB
                        RejectReasonBusiness rejectReasonBusiness = new RejectReasonBusiness();
                        if (rejectReasonBusiness.InsertRow(dbTransaction, Mapper._RejectReason) > 0)
                        {
                            dbTransaction.Commit();
                            rejectReasonDTO.Id = Mapper._RejectReason.Id;
                        }

                        else
                        {
                            dbTransaction.Rollback();
                            throw new DataException("DataBase Operation Failure");
                        }
                    }
                    else
                        throw new ArgumentNullException("rejectReasonDTO");
                }
                catch (Exception ex)
                {
                    dbTransaction.Rollback();
                    throw;
                }
            }

            return rejectReasonDTO;
        }
        public RejectReasonDTO UpdateRejectReasonInDB(RejectReasonDTO rejectReasonDTO)
        {
            BaseDataAccess _db = new BaseDataAccess();
            using (DbTransaction dbTransaction = _db.CreateTransaction())
            {
                try

                {
                    // 1- Perform Mapping to  Input (for Saving in DB)
                    if (Mapper.MapRejectReasonAsInput(rejectReasonDTO))
                    {
                        // 2- Select RejectReason to be updated
                        RejectReasonBusiness rejectReasonBusiness = new RejectReasonBusiness();
                        RejectReasonList rejectReasonList = rejectReasonBusiness.SelectRows(Mapper._WorkField.Id, null, null);

                        if (rejectReasonList != null && rejectReasonList.Count > 0)
                        {
                            rejectReasonList[0].Id = Mapper._RejectReason.Id;
                            rejectReasonList[0].name = Mapper._RejectReason.name;
                            rejectReasonList[0].nameAr = Mapper._RejectReason.nameAr;


                            // 3- Update RejectReason Data by Input Values
                            rejectReasonBusiness = new RejectReasonBusiness();
                            if (rejectReasonBusiness.UpdateRow(dbTransaction, rejectReasonList[0]) > 0)
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
                            throw new Exception("RejectReason Id Not Found in DB");
                        }
                    }
                    else
                        throw new ArgumentNullException("rejectReasonDTO");
                }
                catch (Exception ex)
                {
                    dbTransaction.Rollback();
                    throw;
                }
            }

            return rejectReasonDTO;
        }
        public bool DeleteRejectReasonFromDB(int id)
        {
            bool result = default(bool);

            BaseDataAccess _db = new BaseDataAccess();
            using (DbTransaction dbTransaction = _db.CreateTransaction())
            {
                try
                {
                    // 1- Select RejectReason From DB by ID
                    RejectReasonBusiness rejectReasonBusiness = new RejectReasonBusiness();
                    RejectReasonList rejectReasonList = rejectReasonBusiness.SelectRows(id, null, null);

                    if (rejectReasonList != null && rejectReasonList.Count > 0)
                    {
                        foreach (RejectReason rejectReason in rejectReasonList)
                        {
                            rejectReasonBusiness = new RejectReasonBusiness();
                            rejectReasonBusiness.DeleteRow(dbTransaction, rejectReason);
                        }

                        dbTransaction.Commit();
                        result = true;
                    }

                    else
                    {
                        dbTransaction.Rollback();
                        throw new Exception("RejectReason Id Not Found in DB");
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
        private List<RejectReason> fillRejectReasonList()
        {
            RejectReasonBusiness _RejectReasonBusiness = new RejectReasonBusiness();
            RejectReasonList _RejectReasonList = _RejectReasonBusiness.SelectRows(null, null, null);
            return _RejectReasonList;

        }

        
    }
}