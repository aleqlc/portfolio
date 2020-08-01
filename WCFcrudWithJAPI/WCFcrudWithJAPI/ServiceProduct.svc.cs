using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFcrudWithJAPI
{
    // 참고: "리팩터링" 메뉴에서 "이름 바꾸기" 명령을 사용하여 코드, svc 및 config 파일에서 클래스 이름 "ServiceProduct"을 변경할 수 있습니다.
    // 참고: 이 서비스를 테스트하기 위해 WCF 테스트 클라이언트를 시작하려면 솔루션 탐색기에서 ServiceProduct.svc나 ServiceProduct.svc.cs를 선택하고 디버깅을 시작하십시오.
    public class ServiceProduct : IServiceProduct
    {
        public bool create(Product product)
        {
            using (MyDemoEntities mde = new MyDemoEntities())
            {
                try
                {
                    ProductEntity pe = new ProductEntity();
                    pe.Name = product.Name;
                    pe.Price = product.Price;
                    pe.Quantity = product.Quantity;
                    mde.ProductEntities.Add(pe);
                    mde.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool delete(Product product)
        {
            using (MyDemoEntities mde = new MyDemoEntities())
            {
                try
                {
                    int id = Convert.ToInt32(product.Id);
                    ProductEntity pe = mde.ProductEntities.Single(p => p.id == id);
                    mde.ProductEntities.Remove(pe);
                    mde.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            };
        }

        public bool edit(Product product)
        {
            using (MyDemoEntities mde = new MyDemoEntities())
            {
                try
                {
                    int id = Convert.ToInt32(product.Id);
                    ProductEntity pe = mde.ProductEntities.Single(p => p.id == id);
                    pe.Name = product.Name;
                    pe.Price = product.Price;
                    pe.Quantity = product.Quantity;
                    mde.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            };
        }

        public Product find(string id)
        {
            using (MyDemoEntities mde = new MyDemoEntities())
            {
                int nid = Convert.ToInt32(id);
                return mde.ProductEntities.Where(pe => pe.id==nid).Select(pe => new Product
                {
                    Id = pe.id,
                    Name = pe.Name,
                    Price = pe.Price.Value,
                    Quantity = pe.Quantity.Value
                }).First();
            };
        }

        public List<Product> findAll()
        {
            using (MyDemoEntities mde = new MyDemoEntities())
            {
                return mde.ProductEntities.Select(pe => new Product {
                    Id = pe.id,
                    Name=pe.Name,
                    Price=pe.Price.Value,
                    Quantity=pe.Quantity.Value
                }).ToList();
            };
        }
    }
}
