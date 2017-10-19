#!/usr/bin/env python3

# transpiled with BefunCompile v1.3.0 (c) 2017
import gzip, base64
_g = ("Ah+LCAAAAAAABADt0OtLU3EcBvCfd7volAQp2OaKigpdYl5I54glEUqFUStZ6pBminlLnE7zSIG+8AZmC29bvskXRgsrZm257CALbGosXXI82+Skh3nZpsep03mW9qJ/"
  + "ot/z4sPzhe+rh90UDPbjD1ZmDcXYbd/6H0JxdH4eevNZ4akTI2EHf58cDJtdHrqfmHXGkdqOSNp/RksCH/TYpKG5ma8OdGYHK+3zH0LRp1Nvfem1htOqx8wvSsd6pjfK"
  + "GcZxTsbWbkU5b+yXlPV7Vs4lax8hfpJt7dsrAivn8t7pnrcHMHx8GUxfBuef6M6mI4B13J91sfnvlwAKhUKhUCgUCoVCoVAoFAqFQqHQ/948AGhZZaQyhi6LL5Y35XAT"
  + "hMYCr804ESkULhnKk6/1q5Ryl4RlUag1q5IajaW12603uOj3Ne8ON5poP1BvkXEmpTqpvUyj7UwkaJk5g69gFW2qMQvvKKjiEehGKY/W4GieVkW6kpDwdfEACZyIWM00"
  + "jVWYx4WYS2JGRLiuwrxYfqd3sc4zbQoCHoYd+SgKQXJCGvmiYmlcyTS2tLq2xj82wparCS2SP8QAqnk3yxMZa2ZWUsTZT9VdcpQa4W5oJhxmB91k8QceWyVamcVFyXSC"
  + "ZLdqxFkTmFQ9lsRqwC8YMKxNjxMRdAGyPWdYXUvReYsR2aHS7YUmUsTju2RdeqWcukpgaVYfa3d1BmWM8LjntIps0RWvasbdv4uvnJ/ls3+1LJXNtBq1urvXxwQmsk1P"
  + "TKW84dvzj2wAZ8tKjF5NWerobeeukf812oiX6noCbSULKr/PyfG7Gx0URqZV5yhzv4UCywvcLSgaj6PIzp0CqlRAj4662kIZD/nm78YqRdBW4WsGqI2kX86j6fhw8jix"
  + "nXhu2cUEw9zNvb2prepEYjCDcA3xWsYtvQlGnLs5wFakAnK1gxoxDecC6yOvf/jznuZb0WzwB1p9toPEGQAA")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<2017 and y<1013):
        return g[y*2017 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<2017 and y<1013):
        g[y*2017 + x]=v;
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
    gw(1,9,1000)
    gw(2,9,1017)
    gw(3,9,1000000)
    gw(1,2,0)
    gw(1,4,0)
    gw(1,5,gr(3,9))
    sa(gr(3,9)-1)
    sa(0)
    sa(gr(3,9)-1)
    sa(gr(3,9)-1)
    gw((td(gr(3,9)-1,gr(1,9)))+9,tm(gr(3,9)-1,gr(1,9)),0)
    return 1
def _1():
    sa(td(sp(),gr(1,9)))

    sa(sp()+gr(2,9))

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sp(),gr(1,9)))

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());

    return (28)if(sp()!=0)else(2)
def _2():
    gw(1,3,1)
    sp();
    sa(1)
    return 3
def _3():
    sa(2)
    sa(2*gr(1,3))
    sa((1)if((2*gr(1,3))<gr(3,9))else(0))
    return 4
def _4():
    return (27)if(sp()!=0)else(5)
def _5():
    sp();
    sp();
    sa(sp()+1)


    return (6)if((sr()-gr(3,9))!=0)else(7)
def _6():
    sa(sr());
    gw(1,3,sp())
    return 3
def _7():
    gw(2,3,6)
    sp();
    sa(gr((td(6,gr(1,9)))+9,tm(6,gr(1,9))))
    return 8
def _8():
    return (9)if(sp()!=0)else(12)
def _9():
    sa(gr(2,3)+1)

    return (10)if(((gr(2,3)+1)-gr(3,9))!=0)else(11)
def _10():
    sa(sr());
    gw(2,3,sp())
    sa((td(sr(),gr(1,9)))+9)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sp(),gr(1,9)))

    v0=sp()
    sa(gr(sp(),v0))
    return 8
def _11():
    print(gr(1,5),end=" ",flush=True)
    sp();
    return 29
def _12():
    global t0
    sa(gr(2,3))
    sa(gr(2,3))
    gw(7,0,gr(2,3))
    gw(1,2,1)
    sa(td(sp(),gr(1,9)))

    sa(sp()+gr(2,9))

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sp(),gr(1,9)))

    v0=sp()
    t0=gr(sp(),v0)
    gw(2,2,t0)
    return 13
def _13():
    global t0
    t0=gr(2,2)

    return (14)if(gr(2,2)>0)else(9)
def _14():
    global t0
    return (15)if(t0<gr(3,9))else(9)
def _15():
    global t0
    return (16)if((t0-gr(2,3))!=0)else(9)
def _16():
    gw(3,1,0)
    gw(3,2,0)
    sa(0)
    sa(gr(7,0)-gr(2,2))
    return 17
def _17():
    return (23)if(sp()!=0)else(18)
def _18():
    global t0
    global t1
    gw(3,1,1)
    t0=gr(1,2)
    sa(sr());
    sa(t0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(sp()-v0)

    t1=sp()
    gw(3,2,t1)

    return (22)if(gr(3,2)>gr(1,4))else(19)
def _19():
    sp();

    return (9)if((gr(3,1))!=0)else(20)
def _20():
    return (9)if((gr((td(gr(2,2),gr(1,9)))+9,tm(gr(2,2),gr(1,9))))!=0)else(21)
def _21():
    sa(gr(2,2))
    sa(gr(2,2))
    sa(7)
    sa(gr(1,2))
    gw(1,2,gr(1,2)+1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((td(sr(),gr(1,9)))+9)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sp(),gr(1,9)))

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    gw(2,2,gr((td(gr(2,2),gr(1,9)))+gr(2,9),tm(gr(2,2),gr(1,9))))
    return 13
def _22():
    global t0
    gw(1,4,gr(3,2))
    sa(sr());
    sa(7)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    t0=gr(sp(),v0)
    gw(1,5,t0)
    return 23
def _23():
    global t0
    sa(sr());
    sa(7)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    t0=gr(sp(),v0)
    t0=(1)if(t0<gr(1,5))else(0)
    t0=t0*gr(3,1)

    return (26)if((t0)!=0)else(24)
def _24():
    sa(sp()+1)


    return (25)if((sr()-gr(1,2))!=0)else(19)
def _25():
    sa(sr());
    sa(7)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()-gr(2,2))
    return 17
def _26():
    global t0
    sa(sr());
    sa(7)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    t0=gr(sp(),v0)
    gw(1,5,t0)
    return 24
def _27():
    sa(sr());
    sa((td(sr(),gr(1,9)))+gr(2,9))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sp(),gr(1,9)))

    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()+gr(1,3))

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((td(sr(),gr(1,9)))+gr(2,9))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sp(),gr(1,9)))

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()+1)

    sa(sr()*gr(1,3))
    sa((1)if(sr()<gr(3,9))else(0))
    return 4
def _28():
    sa(sp()-1)

    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((td(sr(),gr(1,9)))+9)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sp(),gr(1,9)))

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28]
c=0
while c<29:
    c=m[c]()
