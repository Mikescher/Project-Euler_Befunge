# compiled with BefunCompile v1.0.4 (c) 2015
# execute with at least Python3
import gzip, base64
_g = ("AR+LCAAAAAAABADt1NFOwjAUBuBXGd24WTM9HWzAQhp8AN8At5sl9bJXvTI8u6erEEKGOsVo6v8nhNK1Z+cbFJf801AsmehOYwnccMMNN9xxBG644YYb7jgCN9xwww13"
  + "HIEbbrjhhjuOwA033HDDHUfghhtuuOGOI3DDDTfccMcRuOGGG2644wjcyPXoRDw9Hh4OPs8zIYfkMs8VWdEcpJB5VUke96LMlSzJut9u+SaZrtj+QBcfZWqXoUexFJfN"
  + "7u4MyarKjvNjhbfjW/1vJCQbbWd00lJ1z/ezVF+We5d07RnrYpa67vN1RiqUZBin12Qb2q/JWH6polFF2nYZD/yb6Puwgq/tS0qM5rXKOq14t7JLspoqsvyh5mHNc2ZJ"
  + "Jq/IyIZPydzP2Hqo68sNZV2XkVrx8k2+8hukIjP3I9mshlLF0MJbexuyC77/gsyGjGlefOf+/HHJ4RhmTodr560Pg50+gdxx1nXttKcU0nZtOmsKdfZtTK/zreOis6C0"
  + "2Wnm6tovEW+2/S9ky3/OYZAkr+fUiHQoOQAA")
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
    gw(1,0,357913941)
    gw(10,0,9802)
    gw(2,0,201)
    sa(gr(2,0))
    gw(8,0,52)
    return 21
def _1():
    gw(8,0,100)
    sp()
    sa(100)
    sa(gr(8,0))
    sa(100)
    return 2
def _2():
    sa(gr(2,0))
    gw(gr(2,0),1,0)
    return 22
def _3():
    gw(gr(2,0),1,1)
    sp()
    gw(4,0,sp())
    return 4
def _4():
    gw(5,0,0)
    gw(6,0,gr(2,0))
    return 23
def _5():
    gw(7,0,1)
    sp()
    sa(tm((0)+(gr(gr(7,0),1)),gr(1,0)))
    return 26
def _6():
    sa(gr(2,0))
    gw(9,0,52)
    return 25
def _7():
    sp()
    gw(gr(3,0),gr(9,0),sp())
    sp()
    return 29
def _8():
    gw(8,0,100)
    sa(sr())
    sa(gr(8,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 2
def _9():
    sp()
    print(gr(10,0),end="",flush=True)
    return 32
def _10():
    gw(8,0,sp())
    sa(sr())
    sa(gr(8,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 2
def _11():
    gw(10,0,(gr(10,0))-(1))
    sp()
    return 29
def _12():
    gw(9,0,52)
    return 25
def _13():
    return 32
def _14():
    gw(9,0,sp())
    return 25
def _15():
    sa(9)
    sa(sp()*sp());
    sa(gr(gr(7,0),1))
    sa(sp()+sp());
    sa(gr(1,0))
    v0=sp()
    sa(tm(sp(),v0))
    return 26
def _16():
    gw(6,0,sp())
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    gw(5,0,sp())
    return 23
def _17():
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
    return 22
def _18():
    gw(8,0,52)
    return 21
def _19():
    gw(8,0,sp())
    return 21
def _20():
    sp()
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    return (18)if(sp()!=0)else(1)
def _21():
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
    return (19)if(((gr(8,0))-(1))-(1))else(20)
def _22():
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return (3)if(sp()!=0)else(17)
def _23():
    sa(((gr(gr(6,0),1))*(gr(4,0)))+(gr(5,0)))
    gw(gr(6,0),1,tm(((gr(gr(6,0),1))*(gr(4,0)))+(gr(5,0)),10))
    sa((gr(6,0))-(1))
    return (16)if((gr(6,0))-(1))else(24)
def _24():
    sp()
    sp()
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    return (4)if(sp()!=0)else(5)
def _25():
    gw(3,0,sp())
    sa(sr())
    sa(gr(gr(3,0),gr(9,0)))
    return (28)if(gr(gr(3,0),gr(9,0)))else(7)
def _26():
    sa((gr(7,0))+(1))
    gw(7,0,(gr(7,0))+(1))
    sa(gr(2,0))
    v0=sp()
    sa(sp()-v0)
    sa(1)
    v0=sp()
    sa(sp()-v0)
    return (15)if(sp()!=0)else(6)
def _27():
    sa(gr(3,0))
    sa((gr(9,0))-(1))
    return (14)if(((gr(9,0))-(1))-(1))else(30)
def _28():
    v0=sp()
    sa(sp()-v0)
    sa((0)if(sp()!=0)else(1))
    return (11)if(sp()!=0)else(27)
def _29():
    sa((gr(8,0))-(1))
    return (10)if(((gr(8,0))-(1))-(1))else(31)
def _30():
    sp()
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa(1)
    v0=sp()
    sa(sp()-v0)
    return (12)if(sp()!=0)else(13)
def _31():
    sp()
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa(1)
    v0=sp()
    sa(sp()-v0)
    return (8)if(sp()!=0)else(9)
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31]
c=0
while c<32:
    c=m[c]()