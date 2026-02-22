using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x0200029D RID: 669
	public class Shared<T> : Object
	{
		// Token: 0x06002D39 RID: 11577 RVA: 0x000E5970 File Offset: 0x000E3B70
		// Note: this type is marked as 'beforefieldinit'.
		static Shared()
		{
			Il2CppClassPointerStore<Shared<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "Shared`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Shared<T>>.NativeClassPtr);
			Shared<T>.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shared<T>>.NativeClassPtr, "Value");
			Shared<T>.NativeMethodInfoPtr__ctor_Internal_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shared<T>>.NativeClassPtr, 100670445);
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x000E5A04 File Offset: 0x000E3C04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334403, RefRangeEnd = 334404, XrefRangeStart = 334402, XrefRangeEnd = 334403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Shared(T value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Shared<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Shared<T>.NativeMethodInfoPtr__ctor_Internal_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06002D3B RID: 11579 RVA: 0x0000FE1F File Offset: 0x0000E01F
		public Shared(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06002D3C RID: 11580 RVA: 0x000E5A88 File Offset: 0x000E3C88
		// (set) Token: 0x06002D3D RID: 11581 RVA: 0x000E5AB0 File Offset: 0x000E3CB0
		public unsafe T Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shared<T>.NativeFieldInfoPtr_Value);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shared<T>.NativeFieldInfoPtr_Value);
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

		// Token: 0x0400272E RID: 10030
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x0400272F RID: 10031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_T_0;
	}
}
