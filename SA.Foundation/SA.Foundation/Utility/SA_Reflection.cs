using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace SA.Foundation.Utility
{
	// Token: 0x02000018 RID: 24
	public class SA_Reflection : Object
	{
		// Token: 0x060000AE RID: 174 RVA: 0x00006880 File Offset: 0x00004A80
		// Note: this type is marked as 'beforefieldinit'.
		static SA_Reflection()
		{
			Il2CppClassPointerStore<SA_Reflection>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Utility", "SA_Reflection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Reflection>.NativeClassPtr);
			SA_Reflection.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Reflection>.NativeClassPtr, 100663422);
			SA_Reflection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Reflection>.NativeClassPtr, 100663423);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000068D8 File Offset: 0x00004AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99201, XrefRangeEnd = 99207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateInstance(string typeFullName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeFullName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Reflection.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000691C File Offset: 0x00004B1C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_Reflection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_Reflection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Reflection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000221C File Offset: 0x0000041C
		public SA_Reflection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Object_String_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
