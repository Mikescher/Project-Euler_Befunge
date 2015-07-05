#!/usr/bin/env python3
# compiled with BefunCompile v1.0.6 (c) 2015
import gzip, base64
_g = ("Ah+LCAAAAAAABACT7+ZgAAEWhre3/fMvG0iwP1iftOvdpIwrZdu8TVxjdhQ/CZjKNUNpoaIOi+3HhxvLJZhD/jmbf7NpN9koo20bsf963mbus1mi8/bUfn716OjuDz/+"
  + "Pj16u+DSuvnxcXv4NNkZGB5s6GMYbOCHOtOB8zdaAx5dWG7J9/XJlrlzrj0T+pVoenyL3br2jVu38j1vr4vaYb7s6OmjNyPv92pOS5wofndG8sskncqOVEGxZBkvqVNn"
  + "o8vieyZkna+Qyp6vyVO4Tvns8ddVEbx/Y9wtOA3Pba2VlpN5O6921/vD+39UOfzIuvSv43zzj5vPMqIfV/YZzsn/drdo7qfqdsZ/8zR15unt63kYtP5wCH+tRLTU+u3h"
  + "tdky+tHZr45LPYx/vq2lbXdacN66VdfXtq0X3GO+qbmlzfqNuNdv/19bTP4+nDbz2JXnV02OhbSFBHmp+j1OV/1lUWZ49nbUkeVzTpnwZcbJx9+//+1W0KziWbuvtM24"
  + "3Fkk927O64r9p176eh7Osl2eqKP5vTQq/SPv9pvzmP4eO3J36pxzu22Wb4mZl7/Obp/9mk5+drOnE4L1LJ8HZX+r+fNWqdqr8lzlu1v97+5uyz2wfN/W5fejDjOzf1d+"
  + "/bp2puzbwwffXv728NZFO5k74W+3Tp/9u8D6d8GH+zevtO6ptdgRv+zppms/Y+Nsa0peuDN++3Xtf8T/Gamd6epvVUMv8rV/EJzH6jhBYAYTAwDFa1uflwIAAA==")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<1000 and y<170):
        return g[y*1000 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<1000 and y<170):
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
    gw(1,0,1000)
    gw(2,0,150)
    gw(0,0,150000)
    gw(3,0,2)
    gw(0,3,32)
    gw(1,3,32)
    return 1
def _1():
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3,88)
    sa(gr(3,0)+gr(3,0))
    sa((1)if((gr(3,0)+gr(3,0))<gr(0,0))else(0))
    return 2
def _2():
    return (34)if(sp()!=0)else(3)
def _3():
    sp()
    return 4
def _4():
    sa(gr(3,0)+1)
    gw(3,0,gr(3,0)+1)
    sa(tm(sr(),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))
    sa(sp()+3);
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()-32);
    return 5
def _5():
    return (6)if(sp()!=0)else(4)
def _6():
    return (1)if(gr(0,0)>gr(3,0))else(7)
def _7():
    gw(3,0,1)
    gw(4,0,0)
    return 8
def _8():
    sa(gr(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3)-32)
    return (9)if(gr(0,0)<=gr(3,0))else(31)
def _9():
    gw(5,0,gr(4,0)-1)
    gw(1,2,2)
    gw(2,2,2)
    sp()
    sa(2)
    return 10
def _10():
    sa(sr()+1)
    sa(sr())
    gw(0,1,sp())
    gw(3,1,sp())
    gw(1,1,1)
    sa(0)
    sa(gr(0,3))
    sa((1)if((gr(0,3)*gr(0,3))>gr(0,1))else(0))
    return 11
def _11():
    return (30)if(sp()!=0)else(12)
def _12():
    gw(2,1,1)
    return 13
def _13():
    sa(sr())
    sa(gr(3,1))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(tm(sp(),v0))
    sa((0)if(sp()!=0)else(1))
    return (29)if(sp()!=0)else(14)
def _14():
    gw(1,1,gr(1,1)*gr(2,1))
    return (15)if(gr(3,1)!=1)else(16)
def _15():
    sp()
    sa(sp()+1);
    sa(sr())
    sa(tm(sr(),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))
    sa(sp()+3);
    v0=sp()
    sa(gr(sp(),v0))
    sa(sr())
    sa(sr())
    sa(sp()*sp());
    sa((1)if(sp()>gr(0,1))else(0))
    return 11
def _16():
    gw(2,2,gr(1,1))
    sp()
    sp()
    return 17
def _17():
    return (28)if((gr(1,2)*gr(2,2))>500)else(18)
def _18():
    sa(sp()+1);
    return (19)if(tm(sr(),2)!=0)else(10)
def _19():
    sa(td(sr()+1,2))
    sa(sr())
    gw(0,1,sp())
    gw(3,1,sp())
    gw(1,1,1)
    sa(0)
    sa(gr(0,3))
    sa((1)if((gr(0,3)*gr(0,3))>gr(0,1))else(0))
    return 20
def _20():
    return (27)if(sp()!=0)else(21)
def _21():
    gw(2,1,1)
    return 22
def _22():
    sa(sr())
    sa(gr(3,1))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(tm(sp(),v0))
    sa((0)if(sp()!=0)else(1))
    return (26)if(sp()!=0)else(23)
def _23():
    gw(1,1,gr(1,1)*gr(2,1))
    return (24)if(gr(3,1)!=1)else(25)
def _24():
    sp()
    sa(sp()+1);
    sa(sr())
    sa(tm(sr(),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))
    sa(sp()+3);
    v0=sp()
    sa(gr(sp(),v0))
    sa(sr())
    sa(sr())
    sa(sp()*sp());
    sa((1)if(sp()>gr(0,1))else(0))
    return 20
def _25():
    gw(1,2,gr(1,1))
    sp()
    sp()
    return 17
def _26():
    gw(2,1,gr(2,1)+1)
    sa(sr())
    sa(gr(3,1))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(td(sp(),v0))
    gw(3,1,sp())
    return 22
def _27():
    gw(1,2,gr(1,1)*2)
    sp()
    sp()
    return 17
def _28():
    sa(sr()+1)
    sa(sp()*sp());
    sa(td(sp(),2))
    print(sp(),end="",flush=True)
    return 35
def _29():
    gw(2,1,gr(2,1)+1)
    sa(sr())
    sa(gr(3,1))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(td(sp(),v0))
    gw(3,1,sp())
    return 13
def _30():
    gw(2,2,gr(1,1)*2)
    sp()
    sp()
    return 17
def _31():
    return (32)if(sp()!=0)else(33)
def _32():
    gw(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+3,gr(3,0))
    gw(4,0,gr(4,0)+1)
    gw(3,0,gr(3,0)+1)
    return 8
def _33():
    gw(3,0,gr(3,0)+1)
    return 8
def _34():
    sa(sr())
    sa(32)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sr(),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))
    sa(sp()+3);
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()+gr(3,0));
    sa((1)if(sr()<gr(0,0))else(0))
    return 2
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33,_34]
c=0
while c<35:
    c=m[c]()