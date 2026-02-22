using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace SA.Common.Pattern
{
	// Token: 0x0200030E RID: 782
	public class NonMonoSingleton<T> : Object where T : NonMonoSingleton<T>, new()
	{
		// Token: 0x06002D26 RID: 11558 RVA: 0x000C0AC0 File Offset: 0x000BECC0
		// Note: this type is marked as 'beforefieldinit'.
		static NonMonoSingleton()
		{
			Il2CppClassPointerStore<NonMonoSingleton<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Common.Pattern", "NonMonoSingleton`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NonMonoSingleton<T>>.NativeClassPtr);
			NonMonoSingleton<T>.NativeFieldInfoPtr__Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NonMonoSingleton<T>>.NativeClassPtr, "_Instance");
			NonMonoSingleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonMonoSingleton<T>>.NativeClassPtr, 100669189);
			NonMonoSingleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonMonoSingleton<T>>.NativeClassPtr, 100669190);
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06002D27 RID: 11559 RVA: 0x000C0B68 File Offset: 0x000BED68
		public unsafe static T Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonMonoSingleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x000C0B98 File Offset: 0x000BED98
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NonMonoSingleton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NonMonoSingleton<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonMonoSingleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x000118E3 File Offset: 0x0000FAE3
		public NonMonoSingleton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06002D2A RID: 11562 RVA: 0x000C0BD4 File Offset: 0x000BEDD4
		// (set) Token: 0x06002D2B RID: 11563 RVA: 0x000C0BF8 File Offset: 0x000BEDF8
		public unsafe static T _Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NonMonoSingleton<T>.NativeFieldInfoPtr__Instance, (void*)(&intPtr));
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, false);
			}
			set
			{
				IntPtr nativeFieldInfoPtr__Instance = NonMonoSingleton<T>.NativeFieldInfoPtr__Instance;
				ref T ptr2;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					if (!(t is string))
					{
						ref T ptr = (ptr2 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr) != null)
						{
							ptr2 = ref ptr;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr)))
							{
								ptr2 = IL2CPP.il2cpp_object_unbox(ref ptr);
							}
						}
					}
					else
					{
						ptr2 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr2 = ref value;
				}
				IL2CPP.il2cpp_field_static_set_value(nativeFieldInfoPtr__Instance, (void*)(&ptr2));
			}
		}

		// Token: 0x04002B30 RID: 11056
		private static readonly IntPtr NativeFieldInfoPtr__Instance;

		// Token: 0x04002B31 RID: 11057
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0;

		// Token: 0x04002B32 RID: 11058
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
