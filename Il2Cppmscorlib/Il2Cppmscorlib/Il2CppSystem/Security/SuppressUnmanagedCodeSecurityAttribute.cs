using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security
{
	// Token: 0x020002B9 RID: 697
	public sealed class SuppressUnmanagedCodeSecurityAttribute : Attribute
	{
		// Token: 0x06002ED5 RID: 11989 RVA: 0x00010566 File Offset: 0x0000E766
		// Note: this type is marked as 'beforefieldinit'.
		static SuppressUnmanagedCodeSecurityAttribute()
		{
			Il2CppClassPointerStore<SuppressUnmanagedCodeSecurityAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security", "SuppressUnmanagedCodeSecurityAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SuppressUnmanagedCodeSecurityAttribute>.NativeClassPtr);
			SuppressUnmanagedCodeSecurityAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SuppressUnmanagedCodeSecurityAttribute>.NativeClassPtr, 100670726);
		}

		// Token: 0x06002ED6 RID: 11990 RVA: 0x000EC778 File Offset: 0x000EA978
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SuppressUnmanagedCodeSecurityAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SuppressUnmanagedCodeSecurityAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SuppressUnmanagedCodeSecurityAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ED7 RID: 11991 RVA: 0x0001059F File Offset: 0x0000E79F
		public SuppressUnmanagedCodeSecurityAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002886 RID: 10374
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
