using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020000D0 RID: 208
	public class BasicNode<T> : LinkedPoolItem<BasicNode<T>>
	{
		// Token: 0x06000BAD RID: 2989 RVA: 0x000306CC File Offset: 0x0002E8CC
		// Note: this type is marked as 'beforefieldinit'.
		static BasicNode()
		{
			Il2CppClassPointerStore<BasicNode<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "BasicNode`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicNode<T>>.NativeClassPtr);
			BasicNode<T>.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicNode<T>>.NativeClassPtr, "next");
			BasicNode<T>.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicNode<T>>.NativeClassPtr, "data");
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00007515 File Offset: 0x00005715
		public BasicNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000BAF RID: 2991 RVA: 0x00030760 File Offset: 0x0002E960
		// (set) Token: 0x06000BB0 RID: 2992 RVA: 0x0000751E File Offset: 0x0000571E
		public unsafe BasicNode<T> next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicNode<T>.NativeFieldInfoPtr_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicNode<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicNode<T>.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x00030790 File Offset: 0x0002E990
		// (set) Token: 0x06000BB2 RID: 2994 RVA: 0x000307B8 File Offset: 0x0002E9B8
		public unsafe T data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicNode<T>.NativeFieldInfoPtr_data);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicNode<T>.NativeFieldInfoPtr_data);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x00030860 File Offset: 0x0002EA60
		public void AppendTo(ref BasicNode<T> first)
		{
			bool flag = first == null;
			if (flag)
			{
				first = this;
			}
			else
			{
				BasicNode<T> basicNode = first;
				while (basicNode.next != null)
				{
					basicNode = basicNode.next;
				}
				basicNode.next = this;
			}
		}

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeFieldInfoPtr_next;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeFieldInfoPtr_data;
	}
}
