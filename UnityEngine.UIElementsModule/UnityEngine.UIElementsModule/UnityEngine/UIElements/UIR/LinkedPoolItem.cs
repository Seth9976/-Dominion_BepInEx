using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020000CE RID: 206
	public class LinkedPoolItem<T> : Object
	{
		// Token: 0x06000B98 RID: 2968 RVA: 0x000302E0 File Offset: 0x0002E4E0
		// Note: this type is marked as 'beforefieldinit'.
		static LinkedPoolItem()
		{
			Il2CppClassPointerStore<LinkedPoolItem<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "LinkedPoolItem`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinkedPoolItem<T>>.NativeClassPtr);
			LinkedPoolItem<T>.NativeFieldInfoPtr_poolNext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedPoolItem<T>>.NativeClassPtr, "poolNext");
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00007464 File Offset: 0x00005664
		public LinkedPoolItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x00030360 File Offset: 0x0002E560
		// (set) Token: 0x06000B9B RID: 2971 RVA: 0x00030388 File Offset: 0x0002E588
		public unsafe T poolNext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedPoolItem<T>.NativeFieldInfoPtr_poolNext);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedPoolItem<T>.NativeFieldInfoPtr_poolNext);
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

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeFieldInfoPtr_poolNext;
	}
}
