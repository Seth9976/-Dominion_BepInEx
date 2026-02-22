using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000AB RID: 171
	public sealed class CastHelper<T> : ValueType
	{
		// Token: 0x06001006 RID: 4102 RVA: 0x00041E7C File Offset: 0x0004007C
		// Note: this type is marked as 'beforefieldinit'.
		static CastHelper()
		{
			Il2CppClassPointerStore<CastHelper<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CastHelper`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastHelper<T>>.NativeClassPtr);
			CastHelper<T>.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastHelper<T>>.NativeClassPtr, "t");
			CastHelper<T>.NativeFieldInfoPtr_onePointerFurtherThanT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastHelper<T>>.NativeClassPtr, "onePointerFurtherThanT");
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x0000A01A File Offset: 0x0000821A
		public CastHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x0000A023 File Offset: 0x00008223
		public CastHelper()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastHelper<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06001009 RID: 4105 RVA: 0x00041F10 File Offset: 0x00040110
		// (set) Token: 0x0600100A RID: 4106 RVA: 0x00041F38 File Offset: 0x00040138
		public unsafe T t
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CastHelper<T>.NativeFieldInfoPtr_t);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CastHelper<T>.NativeFieldInfoPtr_t);
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

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x0600100B RID: 4107 RVA: 0x00041FE0 File Offset: 0x000401E0
		// (set) Token: 0x0600100C RID: 4108 RVA: 0x0000A035 File Offset: 0x00008235
		public unsafe IntPtr onePointerFurtherThanT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CastHelper<T>.NativeFieldInfoPtr_onePointerFurtherThanT);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CastHelper<T>.NativeFieldInfoPtr_onePointerFurtherThanT)) = value;
			}
		}

		// Token: 0x04000C2A RID: 3114
		private static readonly IntPtr NativeFieldInfoPtr_t;

		// Token: 0x04000C2B RID: 3115
		private static readonly IntPtr NativeFieldInfoPtr_onePointerFurtherThanT;
	}
}
