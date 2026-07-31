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

			    //This code generated from tDev Powered by Mahat, Build Number :#2024-01-001(Updated on 06-01-2024 12:57PM) on 7/31/2026 9:49:16 AM
			    public class MARKSDAL
			    {
					public virtual string db_connectionstring{get;set;}
					
			 	    public MARKSDAL(string connectionString)
				    {
						
					    db_connectionstring=connectionString;
				    }
				  
			        
              public virtual string Add_MARKS(MARKSModel model)
			  { 
				  String ResponseMessage="";
					 
					try{
							 
                            using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
					        {
						        npsql.Open();
						        using (var dbCommand = new NpgsqlCommand("\"Add_MARKS\"", npsql))
						        {
                                        dbCommand.CommandType = CommandType.StoredProcedure;
						            	
								        					dbCommand.Parameters.AddWithValue("pvar_marksid",NpgsqlDbType.Uuid,(object)model.MARKSid??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_enternumber5",NpgsqlDbType.Integer,(object)model.enternumber5??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_ass11",NpgsqlDbType.Integer,(object)model.ass11??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_ass21",NpgsqlDbType.Integer,(object)model.ass21??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_int11",NpgsqlDbType.Integer,(object)model.int11??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_int21",NpgsqlDbType.Integer,(object)model.int21??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_total1",NpgsqlDbType.Varchar,(object)model.total1??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_intsub1",NpgsqlDbType.Varchar,(object)model.intsub1??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_ass12",NpgsqlDbType.Integer,(object)model.ass12??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_ass22",NpgsqlDbType.Integer,(object)model.ass22??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_int12",NpgsqlDbType.Integer,(object)model.int12??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_int22",NpgsqlDbType.Integer,(object)model.int22??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_total2",NpgsqlDbType.Varchar,(object)model.total2??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_intsub2",NpgsqlDbType.Varchar,(object)model.intsub2??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_ass13",NpgsqlDbType.Integer,(object)model.ass13??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_ass23",NpgsqlDbType.Integer,(object)model.ass23??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_int13",NpgsqlDbType.Integer,(object)model.int13??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_int23",NpgsqlDbType.Integer,(object)model.int23??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_total3",NpgsqlDbType.Varchar,(object)model.total3??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_intsub3",NpgsqlDbType.Varchar,(object)model.intsub3??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_ass14",NpgsqlDbType.Integer,(object)model.ass14??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_ass24",NpgsqlDbType.Integer,(object)model.ass24??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_int14",NpgsqlDbType.Integer,(object)model.int14??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_int24",NpgsqlDbType.Integer,(object)model.int24??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_total4",NpgsqlDbType.Varchar,(object)model.total4??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_intsub4",NpgsqlDbType.Varchar,(object)model.intsub4??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_ass15",NpgsqlDbType.Integer,(object)model.ass15??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_ass25",NpgsqlDbType.Integer,(object)model.ass25??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_int15",NpgsqlDbType.Integer,(object)model.int15??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_int25",NpgsqlDbType.Integer,(object)model.int25??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_total5",NpgsqlDbType.Varchar,(object)model.total5??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_intsub5",NpgsqlDbType.Varchar,(object)model.intsub5??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_ass16",NpgsqlDbType.Integer,(object)model.ass16??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_ass26",NpgsqlDbType.Integer,(object)model.ass26??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_int16",NpgsqlDbType.Integer,(object)model.int16??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_int26",NpgsqlDbType.Integer,(object)model.int26??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_total6",NpgsqlDbType.Varchar,(object)model.total6??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_intsub6",NpgsqlDbType.Varchar,(object)model.intsub6??DBNull.Value);
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
public virtual MARKSModel getById_MARKS(string MARKSid)
									 {
										DataTable dataTable = new DataTable();
										DataSet dataSet = new DataSet();
										try{
												 
												using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
												{
													npsql.Open();
													using (var dbCommand = new NpgsqlCommand("\"getById_sp_MARKS\"", npsql))
													{
														dbCommand.CommandType = CommandType.StoredProcedure;
														dbCommand.Parameters.AddWithValue("pvar_marksid",(object)MARKSid??DBNull.Value);
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
											return ModelConverter.ConvertDataRowToModel<MARKSModel>(row);
										}
										else
										{
											return null;
										}
									 }
			 public virtual string  Update_MARKS(MARKSModel model)
			 { 
				 String ResponseMessage="";
					try{
						 	 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"Update_MARKS\"", npsql))
								{
										dbCommand.CommandType = CommandType.StoredProcedure;
															dbCommand.Parameters.AddWithValue("pvar_marksid",NpgsqlDbType.Uuid,(object)model.MARKSid??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_enternumber5",NpgsqlDbType.Integer,(object)model.enternumber5??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_ass11",NpgsqlDbType.Integer,(object)model.ass11??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_ass21",NpgsqlDbType.Integer,(object)model.ass21??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_int11",NpgsqlDbType.Integer,(object)model.int11??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_int21",NpgsqlDbType.Integer,(object)model.int21??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_total1",NpgsqlDbType.Varchar,(object)model.total1??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_intsub1",NpgsqlDbType.Varchar,(object)model.intsub1??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_ass12",NpgsqlDbType.Integer,(object)model.ass12??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_ass22",NpgsqlDbType.Integer,(object)model.ass22??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_int12",NpgsqlDbType.Integer,(object)model.int12??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_int22",NpgsqlDbType.Integer,(object)model.int22??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_total2",NpgsqlDbType.Varchar,(object)model.total2??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_intsub2",NpgsqlDbType.Varchar,(object)model.intsub2??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_ass13",NpgsqlDbType.Integer,(object)model.ass13??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_ass23",NpgsqlDbType.Integer,(object)model.ass23??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_int13",NpgsqlDbType.Integer,(object)model.int13??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_int23",NpgsqlDbType.Integer,(object)model.int23??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_total3",NpgsqlDbType.Varchar,(object)model.total3??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_intsub3",NpgsqlDbType.Varchar,(object)model.intsub3??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_ass14",NpgsqlDbType.Integer,(object)model.ass14??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_ass24",NpgsqlDbType.Integer,(object)model.ass24??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_int14",NpgsqlDbType.Integer,(object)model.int14??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_int24",NpgsqlDbType.Integer,(object)model.int24??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_total4",NpgsqlDbType.Varchar,(object)model.total4??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_intsub4",NpgsqlDbType.Varchar,(object)model.intsub4??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_ass15",NpgsqlDbType.Integer,(object)model.ass15??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_ass25",NpgsqlDbType.Integer,(object)model.ass25??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_int15",NpgsqlDbType.Integer,(object)model.int15??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_int25",NpgsqlDbType.Integer,(object)model.int25??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_total5",NpgsqlDbType.Varchar,(object)model.total5??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_intsub5",NpgsqlDbType.Varchar,(object)model.intsub5??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_ass16",NpgsqlDbType.Integer,(object)model.ass16??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_ass26",NpgsqlDbType.Integer,(object)model.ass26??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_int16",NpgsqlDbType.Integer,(object)model.int16??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_int26",NpgsqlDbType.Integer,(object)model.int26??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_total6",NpgsqlDbType.Varchar,(object)model.total6??DBNull.Value);

dbCommand.Parameters.AddWithValue("pvar_intsub6",NpgsqlDbType.Varchar,(object)model.intsub6??DBNull.Value);
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
public virtual string  Remove_MARKS(string id,string loginUserID)
			  { 
				  String ResponseMessage="";
					try{ 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"Remove_MARKS\"", npsql))
								{
										dbCommand.CommandType = CommandType.StoredProcedure;
										dbCommand.Parameters.AddWithValue("pvar_marksid",(object)id??DBNull.Value);
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
public virtual System.Data.DataTable MARKS_List()
			  { 
					DataTable dataTable = new DataTable();
                DataSet dataSet = new DataSet(); 

					try{
 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"MARKS_List\"", npsql))
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
			   
			 
public virtual System.Data.DataTable get_all_MARKS(string tenantid)
			  { 

				    DataTable dataTable = new DataTable();
					DataSet dataSet = new DataSet();

					try{
 
							using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
							{
								npsql.Open();
								using (var dbCommand = new NpgsqlCommand("\"get_all_MARKS\"", npsql))
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
public virtual System.Data.DataTable getById_allinfo_MARKS(string MARKSid)
			 {
				DataSet dataSet=new DataSet();
				DataTable dataTable = new DataTable();
				try{
					     
						using (NpgsqlConnection npsql = new NpgsqlConnection(db_connectionstring))
						{
							npsql.Open();
							using (var dbCommand = new NpgsqlCommand("\"getById_sp_all_MARKS\"", npsql))
							{
								dbCommand.CommandType = CommandType.StoredProcedure;
								dbCommand.Parameters.AddWithValue("pvar_marksid",(object)MARKSid??DBNull.Value);
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
