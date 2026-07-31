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

			    //This code generated from tDev Powered by Mahat, Build Number :#2024-01-001(Updated on 06-01-2024 12:57PM) on 7/30/2026 3:25:47 PM
			    public class DEPARTMENTDAL
			    {
					public virtual string db_connectionstring{get;set;}
					
			 	    public DEPARTMENTDAL(string connectionString)
				    {
						
					    db_connectionstring=connectionString;
				    }
				  
			        
              public virtual string Add_Department(DEPARTMENTModel model)
			  { 
				  String ResponseMessage="";
					 
					try{
							 
                            using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
					        {
						        npsql.Open();
						        using (var dbCommand = new NpgsqlCommand("\"Add_Department\"", npsql))
						        {
                                        dbCommand.CommandType = CommandType.StoredProcedure;
						            	
								        					dbCommand.Parameters.AddWithValue("pvar_departmentid",NpgsqlDbType.Uuid,(object)model.DEPARTMENTid??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_departmentname",NpgsqlDbType.Varchar,(object)model.departmentname??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_departmentcode",NpgsqlDbType.Varchar,(object)model.departmentcode??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_hodname",NpgsqlDbType.Varchar,(object)model.hodname??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_hodemail",NpgsqlDbType.Varchar,(object)model.hodemail??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_academyyear",NpgsqlDbType.Varchar,(object)model.academyyear??DBNull.Value);
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
public virtual DEPARTMENTModel getById_DEPARTMENT(string DEPARTMENTid)
									 {
										DataTable dataTable = new DataTable();
										DataSet dataSet = new DataSet();
										try{
												 
												using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
												{
													npsql.Open();
													using (var dbCommand = new NpgsqlCommand("\"getById_sp_DEPARTMENT\"", npsql))
													{
														dbCommand.CommandType = CommandType.StoredProcedure;
														dbCommand.Parameters.AddWithValue("pvar_departmentid",(object)DEPARTMENTid??DBNull.Value);
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
											return ModelConverter.ConvertDataRowToModel<DEPARTMENTModel>(row);
										}
										else
										{
											return null;
										}
									 }
			 public virtual string  Update_Department(DEPARTMENTModel model)
			 { 
				 String ResponseMessage="";
					try{
						 	 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"Update_Department\"", npsql))
								{
										dbCommand.CommandType = CommandType.StoredProcedure;
															dbCommand.Parameters.AddWithValue("pvar_departmentid",NpgsqlDbType.Uuid,(object)model.DEPARTMENTid??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_departmentname",NpgsqlDbType.Varchar,(object)model.departmentname??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_departmentcode",NpgsqlDbType.Varchar,(object)model.departmentcode??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_hodname",NpgsqlDbType.Varchar,(object)model.hodname??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_hodemail",NpgsqlDbType.Varchar,(object)model.hodemail??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_academyyear",NpgsqlDbType.Varchar,(object)model.academyyear??DBNull.Value);
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
public virtual string  Remove_Department(string id,string loginUserID)
			  { 
				  String ResponseMessage="";
					try{ 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"Remove_Department\"", npsql))
								{
										dbCommand.CommandType = CommandType.StoredProcedure;
										dbCommand.Parameters.AddWithValue("pvar_departmentid",(object)id??DBNull.Value);
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
public virtual System.Data.DataTable Department_List()
			  { 
					DataTable dataTable = new DataTable();
                DataSet dataSet = new DataSet(); 

					try{
 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"Department_List\"", npsql))
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
			   
			 
public virtual System.Data.DataTable get_all_DEPARTMENT(string tenantid)
			  { 

				    DataTable dataTable = new DataTable();
					DataSet dataSet = new DataSet();

					try{
 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"get_all_DEPARTMENT\"", npsql))
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
public virtual System.Data.DataTable getById_allinfo_DEPARTMENT(string DEPARTMENTid)
			 {
				DataSet dataSet=new DataSet();
				DataTable dataTable = new DataTable();
				try{
					     
						using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
						{
							npsql.Open();
							using (var dbCommand = new NpgsqlCommand("\"getById_sp_all_DEPARTMENT\"", npsql))
							{
								dbCommand.CommandType = CommandType.StoredProcedure;
								dbCommand.Parameters.AddWithValue("pvar_departmentid",(object)DEPARTMENTid??DBNull.Value);
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
