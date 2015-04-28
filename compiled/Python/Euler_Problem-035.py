# compiled with BefunCompile v1.0.4 (c) 2015
# execute with at least Python3
import gzip, base64
_g = ("Ah+LCAAAAAAABACT7+ZgAAEWhre3D+ZddhBguBBfOPeJkPnZXcfWbtISE38nU71hEtcKnYVKa7iKXh3fvM7LlU+TsVPqyvclFY+/VojOV9sslb/Z/XTqt3ffTi9/zR+/"
  + "efv9vHX5m48W/Pv37Fdx2FVJsPkbrrMwjIJRMAqGPKjYaAQkE0p8/xnWh55/vpGndu6+848zXzxX/LI89MVnnf6Fr06vus+38faG4mz5sIdJU+R5Gd7ckBPbpp6ff23y"
  + "ar2Q2Ak3GBNcfOtmhi/0flppnn05MVK01ir/0vIOxZK3V50fpOyeybc5VTD46b/imumnfhy9O4OfkcFk9YWn6zf/+fHjydn+naXxIaf1przVkU2yztmznKtmb73gV0uG"
  + "nucH/n6rLjJj+LP52uy3h7Oz3bv1WuxCNmrsDvDVP3TZ/J/mf26GBJ/9657NP3P1bGM3A8P+pZL3vKV/3XmU1307dd+MNeYb1zjHbyuN1Xl8MWV35qOXORLJtfY8nw8f"
  + "rYzm7y3SNLtnenmzyZzlro/nLdtp8UmZ+UD3NRmhzzeMy6+3W+md0ltSc791c2Tg9cjdPu633zJ8uJ8R9LBObtfkx1cDdq93kp+Vc8tns/rtJ4wN6Zfe8LDPXie9Uobh"
  + "X9v7FSrdxQ77+RkAAhzLy4wFAAA=")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<2000 and y<516):
        return g[y*2000 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<2000 and y<516):
        g[y*2000 + x]=v;
def td(a,b):
    return bool(random.getrandbits(1))
def td(a,b):
    return ((0)if(b==0)else(a//b))
def tm(a,b):
    return ((0)if(b==0)else(a%b))
s=[]
def sp():
    global s
    if (len(s) == 0):
        return 0
    return s.pop()
def sa(v):
    global s
    s.append(v)
def sr():
    global s
    if (len(s) == 0):
        return 0
    return s[-1]
def _0():
    gw(1,0,2000)
    gw(2,0,500)
    gw(0,0,1000000)
    gw(3,0,2)
    gw(0,3,32)
    gw(1,3,32)
    return 1
def _1():
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+(3),88)
    sa((gr(3,0))+(gr(3,0)))
    sa((1)if((gr(0,0))>((gr(3,0))+(gr(3,0))))else(0))
    return 2
def _2():
    return (22)if(sp()!=0)else(3)
def _3():
    sp()
    return 4
def _4():
    sa((gr(3,0))+(1))
    gw(3,0,(gr(3,0))+(1))
    sa(sr())
    sa(gr(1,0))
    v0=sp()
    sa(tm(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(1,0))
    v0=sp()
    sa(td(sp(),v0))
    sa(3)
    sa(sp()+sp());
    v0=sp()
    sa(gr(sp(),v0))
    sa(32)
    v0=sp()
    sa(sp()-v0)
    return 5
def _5():
    return (6)if(sp()!=0)else(4)
def _6():
    sa((1)if((gr(0,0))>(gr(3,0)))else(0))
    return (1)if(sp()!=0)else(7)
def _7():
    gw(9,0,0)
    gw(3,0,2)
    return 8
def _8():
    sa(gr(3,0))
    sa((gr(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+(3)))-(88))
    return (21)if(sp()!=0)else(9)
def _9():
    gw(5,0,1)
    sa(sr())
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return (13)if(sp()!=0)else(10)
def _10():
    sa(sr())
    sa(2)
    v0=sp()
    sa(tm(sp(),v0))
    sa((0)if(sp()!=0)else(1))
    return (20)if(sp()!=0)else(11)
def _11():
    sa(sr())
    sa(5)
    v0=sp()
    sa(tm(sp(),v0))
    sa((0)if(sp()!=0)else(1))
    return (20)if(sp()!=0)else(12)
def _12():
    gw(5,0,(gr(5,0))+(1))
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(10)
    sa(sp()*sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return (10)if(sp()!=0)else(13)
def _13():
    sp()
    gw(6,0,sp())
    sa(sr())
    gw(7,0,sp())
    return 14
def _14():
    sa(sr())
    sa(sr())
    sa(gr(1,0))
    v0=sp()
    sa(tm(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(1,0))
    v0=sp()
    sa(td(sp(),v0))
    sa(3)
    sa(sp()+sp());
    v0=sp()
    sa(gr(sp(),v0))
    sa(32)
    v0=sp()
    sa(sp()-v0)
    return (15)if(sp()!=0)else(17)
def _15():
    sa(sr())
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(gr(6,0))
    sa(sp()*sp());
    sa(sp()+sp());
    sa((gr(5,0))-(1))
    gw(5,0,(gr(5,0))-(1))
    return (14)if(sp()!=0)else(16)
def _16():
    sa(10)
    print(gr(7,0),end="",flush=True)
    gw(9,0,(gr(9,0))+(1))
    print(chr(sp()),end="",flush=True)
    return 17
def _17():
    sp()
    return 18
def _18():
    sa((gr(3,0))+(1))
    gw(3,0,(gr(3,0))+(1))
    sa(gr(0,0))
    v0=sp()
    sa(sp()-v0)
    sa((0)if(sp()!=0)else(1))
    return (19)if(sp()!=0)else(8)
def _19():
    sa(gr(9,0))
    sa(61)
    print(chr(32),end="",flush=True)
    print(chr(sp()),end="",flush=True)
    print(sp(),end="",flush=True)
    return 23
def _20():
    sp()
    sp()
    return 17
def _21():
    sp()
    return 18
def _22():
    sa(sr())
    sa(32)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(gr(1,0))
    v0=sp()
    sa(tm(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(1,0))
    v0=sp()
    sa(td(sp(),v0))
    sa(3)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(gr(3,0))
    sa(sp()+sp());
    sa(sr())
    sa(gr(0,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return 2
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22]
c=0
while c<23:
    c=m[c]()