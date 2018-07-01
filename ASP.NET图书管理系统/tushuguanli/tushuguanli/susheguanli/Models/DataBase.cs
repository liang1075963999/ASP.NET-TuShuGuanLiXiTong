using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace susheguanli.Models
{
    public class DataBase
    {
        public static int userHao;
        tushuguanliEntities db = new tushuguanliEntities();
        public void Add(Book book)
        {
            db.Book.Add(book);
            db.SaveChanges();
        }
        public void Delete(int shuhao)
        {
            Book book = db.Book.Single(b => b.shuhao == shuhao);
            db.Book.Remove(book);
            db.SaveChanges();
        }
        public IQueryable<Book> Select(int shuhao)
        {
            IQueryable<Book> book = db.Book.Where(b => b.shuhao == shuhao);
            return book;
        }
        public IQueryable<Book> Select(string shuming)
        {
            IQueryable<Book> book = db.Book.Where(b => b.shuming == shuming);
            return book;
        }
        public IQueryable<Book> Select()
        {
            IQueryable<Book> book = db.Book;
            return book;
        }
        public void Update(int shuhao, string shuming, double jiaqian, string zuozhe, string zaiguanceshu, string neirongjianjie)
        {
            Book book = db.Book.Single(b => b.shuhao == shuhao);
            book.shuming = shuming;
            book.jiaqian = jiaqian;
            book.zuozhe = zuozhe;
            book.zaiguanceshu = zaiguanceshu;
            book.neirongjianjie = neirongjianjie;
            db.SaveChanges();
        }
        //**************************************
        public void Add(JieShu jieShu)
        {
            db.JieShu.Add(jieShu);
            db.SaveChanges();
        }
        public IQueryable<JieShu> SelectJie()
        {
            IQueryable<JieShu> book = db.JieShu;
            return book;
        }
        public IQueryable<JieShu> SelectJie(int jieshurenxuehao)
        {
            IQueryable<JieShu> book = db.JieShu.Where(b => b.jieshurenxuehao == jieshurenxuehao);
            return book;
        }
        public void Add(HuanShu huanShu)
        {
            db.HuanShu.Add(huanShu);
            db.SaveChanges();
        }
        public IQueryable<HuanShu> SelectHuan()
        {
            IQueryable<HuanShu> book = db.HuanShu;
            return book;
        }
        public IQueryable<HuanShu> SelectHuan(int huanshurenxuehao)
        {
            IQueryable<HuanShu> book = db.HuanShu.Where(b => b.huanshurenxuehao == huanshurenxuehao);
            return book;
        }
        public int userPanDuan(int userHao, string password1)
        {

            int response = 0;
            try
            {
                db.User.Where(b => b.userbianhao == userHao && b.password == password1).First();
            }
            catch (Exception e)
            {
                response = 1;
            }
            System.Diagnostics.Debug.Write("我收到了" + response);
            return response;
        }
        public IQueryable<User> SelectUser()
        {
            IQueryable<User> user = db.User.Where(b => b.userbianhao == userHao);
            return user;
        }
        public void Add(User user)
        {
            db.User.Add(user);
            db.SaveChanges();
        }
        public void Delete(HuanShu huanShu)
        {
            JieShu jieShu = db.JieShu.Single(b => b.shuhao == huanShu.shuhao && b.jieshurenxuehao == huanShu.huanshurenxuehao);
            db.JieShu.Remove(jieShu);
            db.SaveChanges();
        }
    }
}