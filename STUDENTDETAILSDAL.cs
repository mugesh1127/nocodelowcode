namespace InternalMarksCGPACalculatorApp.DAL{
			    using System;
			    using System.Text;
			    using System.Data;
			    using System.Data.Common;
			    using InternalMarksCGPACalculatorApp.Models;
			    using EncrypDecrypt;
			    using Newtonsoft.Json;
				using Newtonsoft.Json.Linq;
                using Npgsql;
				using NpgsqlTypes;
				using System.Text.RegularExpressions;

			    //This code generated from tDev Powered by Mahat, Build Number :#2024-01-001(Updated on 06-01-2024 12:57PM) on 7/30/2026 4:09:19 PM
			    public class STUDENTDETAILSDAL
			    {
					public virtual string db_connectionstring{get;set;}
					
			 	    public STUDENTDETAILSDAL(string connectionString)
				    {
						
					    db_connectionstring=connectionString;
				    }
				  
			        
              public virtual string Add_Student_Details(STUDENTDETAILSModel model)
			  { 
				  String ResponseMessage="";
					 
					try{
							 
                            using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
					        {
						        npsql.Open();
						        using (var dbCommand = new NpgsqlCommand("\"Add_Student_Details\"", npsql))
						        {
                                        dbCommand.CommandType = CommandType.StoredProcedure;
						            	
								        					dbCommand.Parameters.AddWithValue("pvar_studentdetailsid",NpgsqlDbType.Uuid,(object)model.STUDENTDETAILSid??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_studentname",NpgsqlDbType.Varchar,(object)model.studentname??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_rollnumber",NpgsqlDbType.Varchar,(object)model.rollnumber??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_registernumber",NpgsqlDbType.Varchar,(object)model.registernumber??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_admissionnumber",NpgsqlDbType.Varchar,(object)model.admissionnumber??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_dateofbirth",NpgsqlDbType.Date,(object)model.dateofbirth??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_department",NpgsqlDbType.Varchar,(object)model.department??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_sec",NpgsqlDbType.Varchar,(object)model.sec??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_mobilenumber",NpgsqlDbType.Varchar,(object)model.mobilenumber??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_emailaddress",NpgsqlDbType.Varchar,(object)model.emailaddress??DBNull.Value);
dbCommand.Parameters.AddWithValue("pvar_createduser",NpgsqlDbType.Uuid,(object)model.createduser??DBNull.Value);	
					

                                        NpgsqlParameter outParm = new NpgsqlParameter("pvar_returnMessage", NpgsqlDbType.Varchar)
                                        {
                                             Direction = ParameterDirection.Output
                                        };
                                        dbCommand.Parameters.Add(outParm);

                                        dbCommand.ExecuteNonQuery();
								        ResponseMessage = outParm.Value.ToString();
								        if (dbCommand.Connection.State != ConnectionState.Closed)
                    			        {
										         dbCommand.Connection.Dispose();
								        }

						        }
						        npsql.Close();
					        }
 

					}catch(Exception ex){
						ResponseMessage=ex.Message;
						Console.WriteLine(ex);
					} 
					
					return ResponseMessage;

			   }
public virtual STUDENTDETAILSModel getById_STUDENTDETAILS(string STUDENTDETAILSid)
									 {
										DataTable dataTable = new DataTable();
										DataSet dataSet = new DataSet();
										try{
												 
												using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
												{
													npsql.Open();
													using (var dbCommand = new NpgsqlCommand("\"getById_sp_STUDENTDETAILS\"", npsql))
													{
														dbCommand.CommandType = CommandType.StoredProcedure;
														dbCommand.Parameters.AddWithValue("pvar_studentdetailsid",(object)STUDENTDETAILSid??DBNull.Value);
														using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(dbCommand))
														{
															dataSet.Reset();
															dataAdapter.Fill(dataSet);
															dataTable = dataSet.Tables[0];
															if (dbCommand.Connection.State != ConnectionState.Closed)
															{
																dbCommand.Connection.Dispose();
															}
														}
													}
													npsql.Close();
												}
					 
										}catch{
												throw;
										}
										if (dataTable.Rows.Count > 0)
										{
											DataRow row = dataTable.Rows[0];
											return ModelConverter.ConvertDataRowToModel<STUDENTDETAILSModel>(row);
										}
										else
										{
											return null;
										}
									 }
			 public virtual string  Update_Student_Details(STUDENTDETAILSModel model)
			 { 
				 String ResponseMessage="";
					try{
						 	 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"Update_Student_Details\"", npsql))
								{
										dbCommand.CommandType = CommandType.StoredProcedure;
															dbCommand.Parameters.AddWithValue("pvar_studentdetailsid",NpgsqlDbType.Uuid,(object)model.STUDENTDETAILSid??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_studentname",NpgsqlDbType.Varchar,(object)model.studentname??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_rollnumber",NpgsqlDbType.Varchar,(object)model.rollnumber??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_registernumber",NpgsqlDbType.Varchar,(object)model.registernumber??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_admissionnumber",NpgsqlDbType.Varchar,(object)model.admissionnumber??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_dateofbirth",NpgsqlDbType.Date,(object)model.dateofbirth??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_department",NpgsqlDbType.Varchar,(object)model.department??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_sec",NpgsqlDbType.Varchar,(object)model.sec??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_mobilenumber",NpgsqlDbType.Varchar,(object)model.mobilenumber??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_emailaddress",NpgsqlDbType.Varchar,(object)model.emailaddress??DBNull.Value);
dbCommand.Parameters.AddWithValue("pvar_modifieduser",NpgsqlDbType.Uuid,model.modifieduser);	
															
										NpgsqlParameter outParm = new NpgsqlParameter("@returnMessage", NpgsqlDbType.Varchar)
										{
											 Direction = ParameterDirection.Output
										};
										dbCommand.Parameters.Add(outParm);

										dbCommand.ExecuteNonQuery();
										ResponseMessage = outParm.Value.ToString();
										if (dbCommand.Connection.State != ConnectionState.Closed)
										{
												 dbCommand.Connection.Dispose();
										}

								}
								npsql.Close();
							}		 

					}catch(Exception ex){
						ResponseMessage=ex.Message;
					}
					
					return ResponseMessage;

			   }
public virtual string  Remove_Student_Details(string id,string loginUserID)
			  { 
				  String ResponseMessage="";
					try{ 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"Remove_Student_Details\"", npsql))
								{
										dbCommand.CommandType = CommandType.StoredProcedure;
										dbCommand.Parameters.AddWithValue("pvar_studentdetailsid",(object)id??DBNull.Value);
										dbCommand.Parameters.AddWithValue("pvar_modifieduser",(object)loginUserID??DBNull.Value);
										NpgsqlParameter outParm = new NpgsqlParameter("@returnMessage", NpgsqlDbType.Varchar)
										{
											 Direction = ParameterDirection.Output
										};
										dbCommand.Parameters.Add(outParm);

										dbCommand.ExecuteNonQuery();
										ResponseMessage = outParm.Value.ToString();
										if (dbCommand.Connection.State != ConnectionState.Closed)
										{
												 dbCommand.Connection.Dispose();
										}

								}
								npsql.Close();
							}	 

					}catch(Exception ex){
						ResponseMessage=ex.Message;
					}
					
					return ResponseMessage;

			   }
public virtual System.Data.DataTable Student_Details_List()
			  { 
					DataTable dataTable = new DataTable();
                DataSet dataSet = new DataSet(); 

					try{
 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"Student_Details_List\"", npsql))
								{
									dbCommand.CommandType = CommandType.StoredProcedure;
									
									using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(dbCommand))
									{
										dataSet.Reset();
										dataAdapter.Fill(dataSet);
										dataTable = dataSet.Tables[0];
										if (dbCommand.Connection.State != ConnectionState.Closed)
										{
											dbCommand.Connection.Dispose();
										}
									}
								}
								npsql.Close();
							}

						 

					}catch{
						throw;
					}


					return dataTable;	


					 

			   }
			   
			 
public virtual System.Data.DataTable get_all_STUDENTDETAILS(string tenantid)
			  { 

				    DataTable dataTable = new DataTable();
					DataSet dataSet = new DataSet();

					try{
 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"get_all_STUDENTDETAILS\"", npsql))
								{
									dbCommand.CommandType = CommandType.StoredProcedure;
									dbCommand.Parameters.AddWithValue("pvar_tenantid",(object)tenantid??DBNull.Value);
									
									using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(dbCommand))
									{
										dataSet.Reset();
										dataAdapter.Fill(dataSet);
										dataTable = dataSet.Tables[0];
										if (dbCommand.Connection.State != ConnectionState.Closed)
										{
											dbCommand.Connection.Dispose();
										}
									}
								}
								npsql.Close();
							}
						

					}catch{
						throw;
					}
					return dataTable;	


					 

			   }
public virtual System.Data.DataTable getById_allinfo_STUDENTDETAILS(string STUDENTDETAILSid)
			 {
				DataSet dataSet=new DataSet();
				DataTable dataTable = new DataTable();
				try{
					     
						using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
						{
							npsql.Open();
							using (var dbCommand = new NpgsqlCommand("\"getById_sp_all_STUDENTDETAILS\"", npsql))
							{
								dbCommand.CommandType = CommandType.StoredProcedure;
								dbCommand.Parameters.AddWithValue("pvar_studentdetailsid",(object)STUDENTDETAILSid??DBNull.Value);
								using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(dbCommand))
								{
									dataSet.Reset();
									dataAdapter.Fill(dataSet);
									dataTable = dataSet.Tables[0];
									if (dbCommand.Connection.State != ConnectionState.Closed)
									{
										dbCommand.Connection.Dispose();
									}
								}
							}
							npsql.Close();
						}
					 
				}catch{
						throw;
				}
				return dataTable;
			 }
			  







			    }


			    }
