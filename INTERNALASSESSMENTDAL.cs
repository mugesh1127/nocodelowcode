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

			    //This code generated from tDev Powered by Mahat, Build Number :#2024-01-001(Updated on 06-01-2024 12:57PM) on 7/31/2026 9:49:26 AM
			    public class INTERNALASSESSMENTDAL
			    {
					public virtual string db_connectionstring{get;set;}
					
			 	    public INTERNALASSESSMENTDAL(string connectionString)
				    {
						
					    db_connectionstring=connectionString;
				    }
				  
			        
              public virtual string Add_Internal_Assessment(INTERNALASSESSMENTModel model)
			  { 
				  String ResponseMessage="";
					 
					try{
							 
                            using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
					        {
						        npsql.Open();
						        using (var dbCommand = new NpgsqlCommand("\"Add_Internal_Assessment\"", npsql))
						        {
                                        dbCommand.CommandType = CommandType.StoredProcedure;
						            	
								        					dbCommand.Parameters.AddWithValue("pvar_internalassessmentid",NpgsqlDbType.Uuid,(object)model.INTERNALASSESSMENTid??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_assessmentid",NpgsqlDbType.Varchar,(object)model.assessmentid??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_studentid",NpgsqlDbType.Varchar,(object)model.studentid??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_subjectcode",NpgsqlDbType.Uuid,(object)model.subjectcode??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_coursecode",NpgsqlDbType.Varchar,(object)model.coursecode??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_internals",NpgsqlDbType.Varchar,(object)model.internals??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_maxmarks",NpgsqlDbType.Integer,(object)model.maxmarks??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_marksobtained",NpgsqlDbType.Integer,(object)model.marksobtained??DBNull.Value);
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
public virtual INTERNALASSESSMENTModel getById_INTERNALASSESSMENT(string INTERNALASSESSMENTid)
									 {
										DataTable dataTable = new DataTable();
										DataSet dataSet = new DataSet();
										try{
												 
												using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
												{
													npsql.Open();
													using (var dbCommand = new NpgsqlCommand("\"getById_sp_INTERNALASSESSMENT\"", npsql))
													{
														dbCommand.CommandType = CommandType.StoredProcedure;
														dbCommand.Parameters.AddWithValue("pvar_internalassessmentid",(object)INTERNALASSESSMENTid??DBNull.Value);
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
											return ModelConverter.ConvertDataRowToModel<INTERNALASSESSMENTModel>(row);
										}
										else
										{
											return null;
										}
									 }
			 public virtual string  Update_Internal_Assessment(INTERNALASSESSMENTModel model)
			 { 
				 String ResponseMessage="";
					try{
						 	 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"Update_Internal_Assessment\"", npsql))
								{
										dbCommand.CommandType = CommandType.StoredProcedure;
															dbCommand.Parameters.AddWithValue("pvar_internalassessmentid",NpgsqlDbType.Uuid,(object)model.INTERNALASSESSMENTid??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_assessmentid",NpgsqlDbType.Varchar,(object)model.assessmentid??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_studentid",NpgsqlDbType.Varchar,(object)model.studentid??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_subjectcode",NpgsqlDbType.Uuid,(object)model.subjectcode??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_coursecode",NpgsqlDbType.Varchar,(object)model.coursecode??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_internals",NpgsqlDbType.Varchar,(object)model.internals??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_maxmarks",NpgsqlDbType.Integer,(object)model.maxmarks??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_marksobtained",NpgsqlDbType.Integer,(object)model.marksobtained??DBNull.Value);
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
public virtual string  Remove_Internal_Assessment(string id,string loginUserID)
			  { 
				  String ResponseMessage="";
					try{ 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"Remove_Internal_Assessment\"", npsql))
								{
										dbCommand.CommandType = CommandType.StoredProcedure;
										dbCommand.Parameters.AddWithValue("pvar_internalassessmentid",(object)id??DBNull.Value);
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
public virtual System.Data.DataTable Internal_Assessment_List(string subjectcode
,string coursecode
,string internals
)
			  { 
					DataTable dataTable = new DataTable();
                DataSet dataSet = new DataSet(); 

					try{
 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"Internal_Assessment_List\"", npsql))
								{
									dbCommand.CommandType = CommandType.StoredProcedure;
									dbCommand.Parameters.AddWithValue("pvar_subjectcode",(object)subjectcode??DBNull.Value);
dbCommand.Parameters.AddWithValue("pvar_coursecode",(object)coursecode??DBNull.Value);
dbCommand.Parameters.AddWithValue("pvar_internals",(object)internals??DBNull.Value);

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
			   
			 
public virtual System.Data.DataTable get_all_INTERNALASSESSMENT(string tenantid)
			  { 

				    DataTable dataTable = new DataTable();
					DataSet dataSet = new DataSet();

					try{
 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"get_all_INTERNALASSESSMENT\"", npsql))
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
public virtual System.Data.DataTable getById_allinfo_INTERNALASSESSMENT(string INTERNALASSESSMENTid)
			 {
				DataSet dataSet=new DataSet();
				DataTable dataTable = new DataTable();
				try{
					     
						using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
						{
							npsql.Open();
							using (var dbCommand = new NpgsqlCommand("\"getById_sp_all_INTERNALASSESSMENT\"", npsql))
							{
								dbCommand.CommandType = CommandType.StoredProcedure;
								dbCommand.Parameters.AddWithValue("pvar_internalassessmentid",(object)INTERNALASSESSMENTid??DBNull.Value);
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
			  
public virtual System.Data.DataTable lookup_INTERNALASSESSMENT_subjectcode()
							        {
                                            DataSet dataSet = new DataSet();
									        DataTable dataTable=new DataTable();
									        try{

                                        		        using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
					                                    {
						                                    npsql.Open();
						                                    using (var dbCommand = new NpgsqlCommand("\"lookup_INTERNALASSESSMENT_subjectcode\"", npsql))
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


						public virtual System.Data.DataTable lookup_change_INTERNALASSESSMENT_subjectcode(string SUBJECTid)
						{
							DataTable dataTable=new DataTable();
                            DataSet dataSet=new DataSet();
							try
							{
								 	 
                                    using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
									{
										npsql.Open();
										using (var dbCommand = new NpgsqlCommand("\"lookup_change_INTERNALASSESSMENT_subjectcode\"", npsql))
										{
											dbCommand.CommandType = CommandType.StoredProcedure;
											dbCommand.Parameters.AddWithValue("pvar_subjectid",NpgsqlDbType.Varchar,(object)SUBJECTid??DBNull.Value);
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




public virtual System.Data.DataTable metrics_of_INTERNALASSESSMENT(string subjectcode
,string coursecode
,string internals
)
			  { 
					DataTable dataTable = new DataTable();
                DataSet dataSet = new DataSet(); 

					try{
 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"metrics_of_INTERNALASSESSMENT\"", npsql))
								{
									dbCommand.CommandType = CommandType.StoredProcedure;
									dbCommand.Parameters.AddWithValue("pvar_subjectcode",(object)subjectcode??DBNull.Value);
dbCommand.Parameters.AddWithValue("pvar_coursecode",(object)coursecode??DBNull.Value);
dbCommand.Parameters.AddWithValue("pvar_internals",(object)internals??DBNull.Value);

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
