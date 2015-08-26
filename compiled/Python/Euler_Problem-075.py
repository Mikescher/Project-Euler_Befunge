#!/usr/bin/env python3
# compiled with BefunCompile v1.0.7 (c) 2015
import gzip, base64
_g = ("Ah+LCAAAAAAABACT7+ZgAAEWhre3/LNvG0iwP1i/yPTlUbXVqdvzlJoi+a3Lj8v6RJl1JZacmaK7/Otuf07ZXEnrN/zZZ+cdV4iexrfrz59Tftsevr0tcO7wz0oLK678"
  + "PLvaHVX/Lff8K6otFRbb/W/369X9D7+oMAiXlZWJlbEzGIQaM4yCUTAKRsEoGPzgnzcjw4w9ejJ35HS6A8KTT0zfPp3dVXBWrHr2qoXeofNfZVm8eZ31+0g2a93585ut"
  + "w3JN9984E/ele8axTZZS1/4XxB6I/8bdWrVmWqrMqqVnDpeUFEb23t0kFaTV171P99WmM7e/nr75LancfFrm1OPBq7oXnf9bc4u/fb3/3oIH/XuqLEPeHm7aK7k69NbU"
  + "j1ON+IS38DrntEX0b9Q9bSi3fJNHZfS+7LDknKDAKz+17ksmzxX7nszEf/ni27IX/L83eufKdO3eW73qcUGUSaGGf9fjO+ecNvY8rjv2ff2Hw4HBfJrnv1rKzVuvl26p"
  + "vrMvWfi4740pH/MS7p499OejfabZ97vdb3Nqb4b/3CLxyEjzg4Hnz617Yp9s/1T2f3VU6Pf2nZ5/lcKOCtzecu+YOz+jZzvnrad7/hg+31n1vtguPv/Tkp0Vh4u/824s"
  + "fMX7Q1acAQDKcaipZwcAAA==")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<1000 and y<1515):
        return g[y*1000 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<1000 and y<1515):
        g[y*1000 + x]=v;
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
    gw(2,0,1000)
    gw(3,0,1500000)
    sa(gr(3,0))
    gw(tm(gr(3,0),gr(2,0)),(td(gr(3,0),gr(2,0)))+3,0)
    return 1
def _1():
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((0)if(sp()!=0)else(1))
    return (3)if(sp()!=0)else(2)
def _2():
    sa(sr())
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sr(),gr(2,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(2,0)))
    sa(sp()+3);
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 1
def _3():
    gw(6,0,0)
    gw(8,0,1)
    sp()
    return 4
def _4():
    return (20)if(((gr(8,0)*gr(8,0)*4)+(gr(8,0)*6)+2)>gr(3,0))else(5)
def _5():
    sa(gr(8,0)+1)
    gw(9,0,gr(8,0)+1)
    return 6
def _6():
    global t0
    global t0
    global t1
    global t1
    global t0
    global t0
    global t0
    sa(sr())
    t0=sr()*2
    sa(sp()*t0);
    t1=sp()
    sa(sp()*gr(8,0)*2);
    sa(t1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+sp());
    t0=sp()
    t0=(1)if(t0>gr(3,0))else(0)
    return (19)if((t0)!=0)else(7)
def _7():
    global t0
    global t1
    global t2
    global t3
    global t1
    global t1
    t0=(gr(9,0)*gr(9,0))-(gr(8,0)*gr(8,0))
    gw(2,1,(gr(9,0)*gr(9,0))-(gr(8,0)*gr(8,0)))
    t1=gr(8,0)*gr(9,0)*2
    gw(3,1,gr(8,0)*gr(9,0)*2)
    t2=(gr(9,0)*gr(9,0))+(gr(8,0)*gr(8,0))
    gw(4,1,(gr(9,0)*gr(9,0))+(gr(8,0)*gr(8,0)))
    t3=t1+t2
    t1=t0+t3
    gw(6,1,t1)
    return (18)if(gr(2,1)>gr(3,1))else(8)
def _8():
    sa(1)
    sa((1)if(gr(6,1)>gr(3,0))else(0))
    return 9
def _9():
    return (17)if(sp()!=0)else(10)
def _10():
    global t0
    global t0
    t0=sr()*(((gr(2,1)*7)+gr(3,1))*5)+gr(4,1)
    gw(8,1,t0)
    sa(sr()*gr(6,1))
    sa(tm(sr(),gr(2,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(2,0)))
    sa(sp()+3);
    v0=sp()
    sa(gr(sp(),v0))
    sa(sr())
    return (13)if(sp()!=0)else(11)
def _11():
    sp()
    sa(sr()*gr(6,1))
    sa(gr(8,1))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sr(),gr(2,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(2,0)))
    sa(sp()+3);
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    gw(6,0,gr(6,0)+1)
    return 12
def _12():
    sa(sp()+1);
    sa((1)if((sr()*gr(6,1))>gr(3,0))else(0))
    return 9
def _13():
    return (14)if(sr()!=gr(8,1))else(16)
def _14():
    sa((1)if(sp()<0)else(0))
    return (12)if(sp()!=0)else(15)
def _15():
    sa(sr()*gr(6,1))
    sa(-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sr(),gr(2,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(2,0)))
    sa(sp()+3);
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    gw(6,0,gr(6,0)-1)
    return 12
def _16():
    sp()
    return 12
def _17():
    sp()
    sa(gr(9,0)+1)
    gw(9,0,gr(9,0)+1)
    return 6
def _18():
    global t0
    global t0
    t0=gr(2,1)
    gw(2,1,gr(3,1))
    gw(3,1,t0)
    return 8
def _19():
    gw(8,0,gr(8,0)+1)
    return 4
def _20():
    print(gr(6,0),end="",flush=True)
    return 21
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20]
c=0
while c<21:
    c=m[c]()