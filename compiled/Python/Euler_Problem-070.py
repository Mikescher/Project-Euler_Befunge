#!/usr/bin/env python3
# compiled with BefunCompile v1.0.8 (c) 2015
import gzip, base64
_g = ("AR+LCAAAAAAABADtmFFr3DAMgP+KcO5g2KSxlaTJRHD3svc99sHkjh6HYXTMlNZP1/8+eTvYul5LSmm3B33ESizJsizbL8m2AKU1DXy5+f51v7uFz3fX+xuoS//qev8N"
  + "Bgvvy263e+cZl3BxcXz+JypBEARBEARBEARBEARBEIQ341//AT2N73t9rsnZ1A+a0Cbd2YStTQo/KO1cUvf8RpcsYnIOuY8ISmvduuSyt+z6M1D2kaUNuXyH2sEEjzVL"
  + "ycmOetSaqLQx8VytJQVq0ejNXG2jbaPtJkDIpu9p8sH5jzrQ4YRmca3UpWpt5GLFdWDRtIbTip6boc7GsD06VnmzKlpniMvzp3/kNdQHGMCvA1XzoWo4l7CaYHykeSVz"
  + "Mm0TrQtrFhR4XuKY89MD2OpXUAVfcWkqoMpszPy3JueF0+fo3GuX8CutZ1IuSWeozVQvDOapw0QPN+RS1bxf5Iyn/gljh7HHqGlAPolxy5oBI7KGDa7ui9A08v1gVbHO"
  + "ebO0Tse8Vjz07NMJS4bFR+G0X/5tfdmZmvka1dEhmYcbWaJMzxkX5Zq4fDgmdBGHl+T1Awao0RSKGwAA")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<150 and y<47):
        return g[y*150 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<150 and y<47):
        g[y*150 + x]=v;
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
    gw(1,0,150)
    gw(2,0,35)
    gw(4,0,5250)
    gw(3,0,2)
    gw(1,1,2000)
    gw(2,1,5000)
    gw(2,2,0)
    gw(1,2,1)
    gw(3,1,10000000)
    return 1
def _1():
    gw(0,3,32)
    gw(1,3,32)
    gw(8,0,1073741824)
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3,88)
    sa(gr(3,0)+gr(3,0))
    sa((1)if((gr(3,0)+gr(3,0))<gr(4,0))else(0))
    return 2
def _2():
    return (38)if(sp()!=0)else(3)
def _3():
    sp()
    return 4
def _4():
    global t0
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
    t0=gr(sp(),v0)
    t0=t0-32
    return 5
def _5():
    global t0
    return (6)if((t0)!=0)else(4)
def _6():
    return (1)if(gr(4,0)>gr(3,0))else(7)
def _7():
    gw(3,0,0)
    sa(gr(1,1))
    gw(4,2,gr(1,1))
    return 8
def _8():
    global t0
    sa(sr())
    sa(tm(sr(),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))
    sa(sp()+3);
    v0=sp()
    t0=gr(sp(),v0)
    t0=t0-88
    return (9)if((t0)!=0)else(12)
def _9():
    sa(sp()+1);
    return (10)if(sr()!=gr(2,1))else(11)
def _10():
    sa(sr())
    gw(4,2,sp())
    return 8
def _11():
    print(gr(1,2),end="",flush=True)
    sp()
    return 39
def _12():
    sa(sr()+1)
    return 13
def _13():
    global t0
    sa(sr())
    gw(5,2,sp())
    sa(sr())
    sa(tm(sr(),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))
    sa(sp()+3);
    v0=sp()
    t0=gr(sp(),v0)
    t0=t0-88
    return (16)if((t0)!=0)else(14)
def _14():
    global t0
    t0=gr(4,2)*gr(5,2)
    gw(7,2,gr(4,2)*gr(5,2))
    t0=(1)if(t0>gr(3,1))else(0)
    return (17)if((t0)!=0)else(15)
def _15():
    global t0
    global t1
    global t2
    t0=gr(7,2)*gr(2,2)
    t1=(gr(4,2)-1)*(gr(5,2)-1)
    gw(8,2,(gr(4,2)-1)*(gr(5,2)-1))
    t1=t1*gr(1,2)
    t2=(1)if(t0>t1)else(0)
    return (16)if((t2)!=0)else(18)
def _16():
    sa(sp()+1);
    return (13)if(sr()!=gr(2,1))else(17)
def _17():
    sp()
    return 9
def _18():
    sa(0)
    sa(tm(gr(7,2),10))
    sa(gr(7,2))
    sa(gr(7,2))
    return 19
def _19():
    return (20)if(sp()!=0)else(24)
def _20():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(9)
    return 21
def _21():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return (23)if(sp()!=0)else(22)
def _22():
    sp()
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),10))
    sa(tm(sr(),10))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return 19
def _23():
    sa(sp()-1);
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*9);
    return 21
def _24():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sp()
    sp()
    return 25
def _25():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return (26)if(sp()!=0)else(27)
def _26():
    sa(sp()+sp());
    return 25
def _27():
    sa(sp()+sp());
    sa(0)
    sa(tm(gr(8,2),10))
    sa(gr(8,2))
    sa(gr(8,2))
    return 28
def _28():
    return (29)if(sp()!=0)else(33)
def _29():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(9)
    return 30
def _30():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return (32)if(sp()!=0)else(31)
def _31():
    sp()
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),10))
    sa(tm(sr(),10))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return 28
def _32():
    sa(sp()-1);
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*9);
    return 30
def _33():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sp()
    sp()
    return 34
def _34():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return (37)if(sp()!=0)else(35)
def _35():
    global t0
    global t1
    sa(sp()+sp());
    t0=sp()
    sa(sp()-t0);
    t1=sp()
    return (16)if((t1)!=0)else(36)
def _36():
    gw(1,2,gr(7,2))
    gw(2,2,gr(8,2))
    return 16
def _37():
    sa(sp()+sp());
    return 34
def _38():
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
    sa((1)if(sr()<gr(4,0))else(0))
    return 2
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33,_34,_35,_36,_37,_38]
c=0
while c<39:
    c=m[c]()