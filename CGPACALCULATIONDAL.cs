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

			    //This code generated from tDev Powered by Mahat, Build Number :#2024-01-001(Updated on 06-01-2024 12:57PM) on 7/31/2026 6:38:39 AM
			    public class CGPACALCULATIONDAL
			    {
					public virtual string db_connectionstring{get;set;}
					
			 	    public CGPACALCULATIONDAL(string connectionString)
				    {
						
					    db_connectionstring=connectionString;
				    }
				  
			        
              public virtual string Add_CGPA_Calculation(CGPACALCULATIONModel model)
			  { 
				  String ResponseMessage="";
					 
					try{
							 
                            using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
					        {
						        npsql.Open();
						        using (var dbCommand = new NpgsqlCommand("\"Add_CGPA_Calculation\"", npsql))
						        {
                                        dbCommand.CommandType = CommandType.StoredProcedure;
						            	
								        					dbCommand.Parameters.AddWithValue("pvar_cgpacalculationid",NpgsqlDbType.Uuid,(object)model.CGPACALCULATIONid??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_enternumberofsemesters",NpgsqlDbType.Integer,(object)model.enternumberofsemesters??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_entersgpa1",NpgsqlDbType.Numeric,(object)model.entersgpa1??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_entersgpa2",NpgsqlDbType.Numeric,(object)model.entersgpa2??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_entersgpa3",NpgsqlDbType.Numeric,(object)model.entersgpa3??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_entersgpa4",NpgsqlDbType.Numeric,(object)model.entersgpa4??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_entersgpa5",NpgsqlDbType.Numeric,(object)model.entersgpa5??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_entersgpa6",NpgsqlDbType.Numeric,(object)model.entersgpa6??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_entersgpa7",NpgsqlDbType.Numeric,(object)model.entersgpa7??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_entersgpa8",NpgsqlDbType.Numeric,(object)model.entersgpa8??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_totalmarks",NpgsqlDbType.Varchar,(object)model.totalmarks??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_cgpa",NpgsqlDbType.Varchar,(object)model.cgpa??DBNull.Value);
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
public virtual CGPACALCULATIONModel getById_CGPACALCULATION(string CGPACALCULATIONid)
									 {
										DataTable dataTable = new DataTable();
										DataSet dataSet = new DataSet();
										try{
												 
												using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
												{
													npsql.Open();
													using (var dbCommand = new NpgsqlCommand("\"getById_sp_CGPACALCULATION\"", npsql))
													{
														dbCommand.CommandType = CommandType.StoredProcedure;
														dbCommand.Parameters.AddWithValue("pvar_cgpacalculationid",(object)CGPACALCULATIONid??DBNull.Value);
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
											return ModelConverter.ConvertDataRowToModel<CGPACALCULATIONModel>(row);
										}
										else
										{
											return null;
										}
									 }
			 public virtual string  Update_CGPA_Calculation(CGPACALCULATIONModel model)
			 { 
				 String ResponseMessage="";
					try{
						 	 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"Update_CGPA_Calculation\"", npsql))
								{
										dbCommand.CommandType = CommandType.StoredProcedure;
															dbCommand.Parameters.AddWithValue("pvar_cgpacalculationid",NpgsqlDbType.Uuid,(object)model.CGPACALCULATIONid??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_enternumberofsemesters",NpgsqlDbType.Integer,(object)model.enternumberofsemesters??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_entersgpa1",NpgsqlDbType.Numeric,(object)model.entersgpa1??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_entersgpa2",NpgsqlDbType.Numeric,(object)model.entersgpa2??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_entersgpa3",NpgsqlDbType.Numeric,(object)model.entersgpa3??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_entersgpa4",NpgsqlDbType.Numeric,(object)model.entersgpa4??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_entersgpa5",NpgsqlDbType.Numeric,(object)model.entersgpa5??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_entersgpa6",NpgsqlDbType.Numeric,(object)model.entersgpa6??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_entersgpa7",NpgsqlDbType.Numeric,(object)model.entersgpa7??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_entersgpa8",NpgsqlDbType.Numeric,(object)model.entersgpa8??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_totalmarks",NpgsqlDbType.Varchar,(object)model.totalmarks??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_cgpa",NpgsqlDbType.Varchar,(object)model.cgpa??DBNull.Value);
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
public virtual string  Remove_CGPA_Calculation(string id,string loginUserID)
			  { 
				  String ResponseMessage="";
					try{ 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"Remove_CGPA_Calculation\"", npsql))
								{
										dbCommand.CommandType = CommandType.StoredProcedure;
										dbCommand.Parameters.AddWithValue("pvar_cgpacalculationid",(object)id??DBNull.Value);
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
public virtual System.Data.DataTable CGPA_Calculation_List()
			  { 
					DataTable dataTable = new DataTable();
                DataSet dataSet = new DataSet(); 

					try{
 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"CGPA_Calculation_List\"", npsql))
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
			   
			 
public virtual System.Data.DataTable get_all_CGPACALCULATION(string tenantid)
			  { 

				    DataTable dataTable = new DataTable();
					DataSet dataSet = new DataSet();

					try{
 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"get_all_CGPACALCULATION\"", npsql))
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
public virtual System.Data.DataTable getById_allinfo_CGPACALCULATION(string CGPACALCULATIONid)
			 {
				DataSet dataSet=new DataSet();
				DataTable dataTable = new DataTable();
				try{
					     
						using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
						{
							npsql.Open();
							using (var dbCommand = new NpgsqlCommand("\"getById_sp_all_CGPACALCULATION\"", npsql))
							{
								dbCommand.CommandType = CommandType.StoredProcedure;
								dbCommand.Parameters.AddWithValue("pvar_cgpacalculationid",(object)CGPACALCULATIONid??DBNull.Value);
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
