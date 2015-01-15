# compiled with BefunCompile v1.0.3 (c) 2015
# execute with at least Python3
from random import randint
import gzip, base64
_g="AR+LCAAAAAAABADt1NFOwjAUBuBXGd24WTM9HWzAQhp8AN8At5sl9bJXvTI8u6erEEKGOsVo6v8nhNK1Z+cbFJf801AsmehOYwnccMMNN9xxBG644YYb7jgCN9xwww13HIEbbrjhhjuOwA033HDDHUfghhtuuOGOI3DDDTfccMcRuOGGG2644wjcyPXoRDw9Hh4OPs8zIYfkMs8VWdEcpJB5VUke96LMlSzJut9u+SaZrtj+QBcfZWqXoUexFJfN7u4MyarKjvNjhbfjW/1vJCQbbWd00lJ1z/ezVF+We5d07RnrYpa67vN1RiqUZBin12Qb2q/JWH6polFF2nYZD/yb6Puwgq/tS0qM5rXKOq14t7JLspoqsvyh5mHNc2ZJJq/IyIZPydzP2Hqo68sNZV2XkVrx8k2+8hukIjP3I9mshlLF0MJbexuyC77/gsyGjGlefOf+/HHJ4RhmTodr560Pg50+gdxx1nXttKcU0nZtOmsKdfZtTK/zreOis6C02Wnm6tovEW+2/S9ky3/OYZAkr+fUiHQoOQAA"
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<248 and y<59):
        return g[y*248 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<248 and y<59):
        g[y*248 + x]=v;
def rd():
    return bool(random.getrandbits(1))
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
    return (42)if(sp()!=0)else(15)
def _1():
    return (18)if(sp()!=0)else(41)
def _2():
    return (19)if(sp()!=0)else(22)
def _3():
    return (39)if(sp()!=0)else(24)
def _4():
    return (33)if(sp()!=0)else(34)
def _5():
    return (29)if(sp()!=0)else(30)
def _6():
    return (36)if(sp()!=0)else(37)
def _7():
    return (43)if(((gr(8,0))-(1))-(1))else(14)
def _8():
    return (40)if((gr(6,0))-(1))else(21)
def _9():
    return (32)if(gr(gr(3,0),gr(9,0)))else(26)
def _10():
    return (31)if(((gr(8,0))-(1))-(1))else(28)
def _11():
    return (38)if(((gr(9,0))-(1))-(1))else(35)
def _12():
    gw(1,0,357913941)
    gw(10,0,9802)
    gw(2,0,201)
    sa(gr(2,0))
    gw(8,0,52)
    return 13
def _13():
    sa(sr())
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(8,0))
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa((gr(8,0))-(1))
    return 7
def _14():
    sp()
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    return 0
def _15():
    gw(8,0,100)
    sp()
    sa(100)
    sa(gr(8,0))
    sa(100)
    return 16
def _16():
    sa(gr(2,0))
    gw(gr(2,0),1,0)
    return 17
def _17():
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return 1
def _18():
    gw(gr(2,0),1,1)
    sp()
    gw(4,0,sp())
    return 19
def _19():
    gw(5,0,0)
    gw(6,0,gr(2,0))
    return 20
def _20():
    sa(((gr(gr(6,0),1))*(gr(4,0)))+(gr(5,0)))
    gw(gr(6,0),1,tm(((gr(gr(6,0),1))*(gr(4,0)))+(gr(5,0)),10))
    sa((gr(6,0))-(1))
    return 8
def _21():
    sp()
    sp()
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    return 2
def _22():
    gw(7,0,1)
    sp()
    sa(tm((0)+(gr(gr(7,0),1)),gr(1,0)))
    return 23
def _23():
    sa((gr(7,0))+(1))
    gw(7,0,(gr(7,0))+(1))
    sa(gr(2,0))
    v0=sp()
    sa(sp()-v0)
    sa(1)
    v0=sp()
    sa(sp()-v0)
    return 3
def _24():
    sa(gr(2,0))
    gw(9,0,52)
    return 25
def _25():
    gw(3,0,sp())
    sa(sr())
    sa(gr(gr(3,0),gr(9,0)))
    return 9
def _26():
    sp()
    gw(gr(3,0),gr(9,0),sp())
    sp()
    return 27
def _27():
    sa((gr(8,0))-(1))
    return 10
def _28():
    sp()
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa(1)
    v0=sp()
    sa(sp()-v0)
    return 5
def _29():
    gw(8,0,100)
    sa(sr())
    sa(gr(8,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 16
def _30():
    sp()
    print(gr(10,0),end="",flush=True)
    return 44
def _31():
    gw(8,0,sp())
    sa(sr())
    sa(gr(8,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 16
def _32():
    v0=sp()
    sa(sp()-v0)
    sa((0)if(sp()!=0)else(1))
    return 4
def _33():
    gw(10,0,(gr(10,0))-(1))
    sp()
    return 27
def _34():
    sa(gr(3,0))
    sa((gr(9,0))-(1))
    return 11
def _35():
    sp()
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa(1)
    v0=sp()
    sa(sp()-v0)
    return 6
def _36():
    gw(9,0,52)
    return 25
def _37():
    return 44
def _38():
    gw(9,0,sp())
    return 25
def _39():
    sa(9)
    sa(sp()*sp());
    sa(gr(gr(7,0),1))
    sa(sp()+sp());
    sa(gr(1,0))
    v0=sp()
    sa(tm(sp(),v0))
    return 23
def _40():
    gw(6,0,sp())
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    gw(5,0,sp())
    return 20
def _41():
    sa(sr())
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 17
def _42():
    gw(8,0,52)
    return 13
def _43():
    gw(8,0,sp())
    return 13
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33,_34,_35,_36,_37,_38,_39,_40,_41,_42,_43]
c=12
while c<44:
    c=m[c]()