using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service {
    public class BaseService {
        Context context = new Context();



        public virtual void Add<T>(params T[] entities)
            where T : class, new() {
            if (entities != null && entities.Length > 0) {
                var set = this.context.Set<T>();
                foreach (var item in entities) {
                    set.Add(item);
                }
            }
        }

        public virtual void Edit<T>(params T[] entities)
         where T : class, new() {
            //还没做
            throw new NotSupportedException();
        }

        public virtual void Delete<T>(params T[] entities)
            where T : class, new() {
            if (entities != null && entities.Length > 0) {
                var set = this.context.Set<T>();
                foreach (var item in entities) {
                    set.Remove(item);
                }
            }
        }

        public virtual T GetByID<T>(Guid id)
            where T : BaseModel, new() {
            return this.context.Set<T>().Where(o => o.ID == id).FirstOrDefault();
        }

        /// <summary>
        /// select all
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity">这里的entity并无实际作用，只是用于编译器推敲类型</param>
        public virtual IQueryable<T> GetList<T>()
            where T : class, new() {
            return this.context.Set<T>();
        }

        /// <summary>
        /// 提交事务
        /// </summary>
        public void Commit() {
            this.context.SaveChanges();
        }
    }
}
