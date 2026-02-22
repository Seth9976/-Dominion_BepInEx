using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq
{
	// Token: 0x02000009 RID: 9
	public class IdentityFunction<TElement> : Object
	{
		// Token: 0x0600007D RID: 125 RVA: 0x000050E4 File Offset: 0x000032E4
		// Note: this type is marked as 'beforefieldinit'.
		static IdentityFunction()
		{
			Il2CppClassPointerStore<IdentityFunction<TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "IdentityFunction`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdentityFunction<TElement>>.NativeClassPtr);
			IdentityFunction<TElement>.NativeMethodInfoPtr_get_Instance_Public_Static_get_Func_2_TElement_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdentityFunction<TElement>>.NativeClassPtr, 100663459);
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00005164 File Offset: 0x00003364
		public unsafe static Func<TElement, TElement> Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58472, XrefRangeEnd = 58500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdentityFunction<TElement>.NativeMethodInfoPtr_get_Instance_Public_Static_get_Func_2_TElement_TElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<TElement, TElement>>(intPtr3) : null;
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002214 File Offset: 0x00000414
		public IdentityFunction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_Func_2_TElement_TElement_0;

		// Token: 0x0200003E RID: 62
		[ObfuscatedName("System.Linq.IdentityFunction`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000210 RID: 528 RVA: 0x0000B3A0 File Offset: 0x000095A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IdentityFunction<TElement>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdentityFunction<TElement>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdentityFunction<TElement>.__c>.NativeClassPtr);
				IdentityFunction<TElement>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdentityFunction<TElement>.__c>.NativeClassPtr, "<>9");
				IdentityFunction<TElement>.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdentityFunction<TElement>.__c>.NativeClassPtr, "<>9__1_0");
				IdentityFunction<TElement>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdentityFunction<TElement>.__c>.NativeClassPtr, 100663461);
				IdentityFunction<TElement>.__c.NativeMethodInfoPtr__get_Instance_b__1_0_Internal_TElement_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdentityFunction<TElement>.__c>.NativeClassPtr, 100663462);
			}

			// Token: 0x06000211 RID: 529 RVA: 0x0000B458 File Offset: 0x00009658
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IdentityFunction<TElement>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdentityFunction<TElement>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000212 RID: 530 RVA: 0x0000B494 File Offset: 0x00009694
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23543, RefRangeEnd = 23544, XrefRangeStart = 23543, XrefRangeEnd = 23544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TElement _get_Instance_b__1_0(TElement x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TElement).IsValueType)
					{
						TElement telement = x;
						intPtr = ((telement is string) ? IL2CPP.ManagedStringToIl2Cpp(telement as string) : IL2CPP.Il2CppObjectBaseToPtr(telement as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref x;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IdentityFunction<TElement>.__c.NativeMethodInfoPtr__get_Instance_b__1_0_Internal_TElement_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<TElement>(intPtr2, false, true);
				}
			}

			// Token: 0x06000213 RID: 531 RVA: 0x00002C73 File Offset: 0x00000E73
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700008C RID: 140
			// (get) Token: 0x06000214 RID: 532 RVA: 0x0000B514 File Offset: 0x00009714
			// (set) Token: 0x06000215 RID: 533 RVA: 0x00002C7C File Offset: 0x00000E7C
			public unsafe static IdentityFunction<TElement>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IdentityFunction<TElement>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IdentityFunction<TElement>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IdentityFunction<TElement>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700008D RID: 141
			// (get) Token: 0x06000216 RID: 534 RVA: 0x0000B53C File Offset: 0x0000973C
			// (set) Token: 0x06000217 RID: 535 RVA: 0x00002C8E File Offset: 0x00000E8E
			public unsafe static Func<TElement, TElement> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IdentityFunction<TElement>.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TElement, TElement>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IdentityFunction<TElement>.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000162 RID: 354
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000163 RID: 355
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04000164 RID: 356
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000165 RID: 357
			private static readonly IntPtr NativeMethodInfoPtr__get_Instance_b__1_0_Internal_TElement_TElement_0;
		}
	}
}
