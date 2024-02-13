using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using WpfKnygute.DAL.Models;

namespace WpfKnygute.DAL
{
    public class RepositoryDal : IRepositoryDAL
    {

        public void Add(Contact contact)
        {
            DbHelper.GetConnection().Open();

            using (var command = new SqlCommand("AddContact", DbHelper.GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@FullName", contact.FullName);
                command.Parameters.AddWithValue("@Number", contact.Number);
                command.Parameters.AddWithValue("@DateOfBirth", contact.DateOfBirth);

                command.ExecuteNonQuery();
            }

            DbHelper.GetConnection().Close();
        }

        public void Delete(int id)
        {
            DbHelper.GetConnection().Open();

            using (var command = new SqlCommand("DeleteContact", DbHelper.GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }

            DbHelper.GetConnection().Close();
        }

        public void Update(Contact contact)
        {
            DbHelper.GetConnection().Open();

            using (var command = new SqlCommand("UpdateContact", DbHelper.GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id", contact.Id);
                command.Parameters.AddWithValue("@FullName", contact.FullName);
                command.Parameters.AddWithValue("@Number", contact.Number);
                command.Parameters.AddWithValue("@DateOfBirth", contact.DateOfBirth);

                command.ExecuteNonQuery();
            }

            DbHelper.GetConnection().Close();
        }

        public List<Contact> GetAllContacts()
        {
            List<Contact> contacts = new List<Contact>();

            DbHelper.GetConnection().Open();

            using (var command = new SqlCommand("SelectAllContacts", DbHelper.GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Contact contact = new Contact(
                            reader["FullName"].ToString(),
                            Convert.ToInt32(reader["Id"]),
                            reader["Number"].ToString(),
                            Convert.ToDateTime(reader["DateOfBirth"])
                            );
                        contacts.Add(contact);
                    }
                }

                DbHelper.GetConnection().Close();

                return contacts;
            }
        }



        //public void Add(Contact contact)
        //{
        //    DbHelper.GetConnection().Open();

        //    DbHelper.GetConnection().Execute("AddContact",
        //        new { 
        //            contact.FullName,
        //            contact.Number,
        //            contact.DateOfBirth
        //        },
        //        commandType: System.Data.CommandType.StoredProcedure
        //        );

        //    DbHelper.GetConnection().Close();
        //}

        //public void Delete(int id)
        //{
        //    DbHelper.GetConnection().Open();

        //    DbHelper.GetConnection().Execute("DeleteContact",
        //        new { Id = id },
        //        commandType: System.Data.CommandType.StoredProcedure
        //        );

        //    DbHelper.GetConnection().Close();
        //}

        //public void Update(Contact contact)
        //{
        //    DbHelper.GetConnection().Open();

        //    DbHelper.GetConnection().Execute("UpdateContact",
        //        contact,
        //        commandType: System.Data.CommandType.StoredProcedure
        //        );

        //    DbHelper.GetConnection().Close();
        //}

        //public List<Contact> GetAllContacts()
        //{
        //    DbHelper.GetConnection().Open();

        //    var contacts = DbHelper.GetConnection().Query<Contact>("SelectAllContacts",
        //        commandType: System.Data.CommandType.StoredProcedure
        //    );

        //    DbHelper.GetConnection().Close();

        //    return contacts.ToList();
        //}
    }
}
