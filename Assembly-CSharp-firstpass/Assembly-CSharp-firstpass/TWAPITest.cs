using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x020000AC RID: 172
public class TWAPITest : MonoBehaviour
{
	// Token: 0x06000C9C RID: 3228 RVA: 0x00042F28 File Offset: 0x00041128
	// Note: this type is marked as 'beforefieldinit'.
	static TWAPITest()
	{
		Il2CppClassPointerStore<TWAPITest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TWAPITest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TWAPITest>.NativeClassPtr);
		TWAPITest.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TWAPITest>.NativeClassPtr, 100664802);
		TWAPITest.NativeMethodInfoPtr_OnResult_Private_Void_TW_APIRequstResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TWAPITest>.NativeClassPtr, 100664803);
		TWAPITest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TWAPITest>.NativeClassPtr, 100664804);
	}

	// Token: 0x06000C9D RID: 3229 RVA: 0x00042F94 File Offset: 0x00041194
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175521, XrefRangeEnd = 175563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TWAPITest.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000C9E RID: 3230 RVA: 0x00042FC8 File Offset: 0x000411C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175563, XrefRangeEnd = 175575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnResult(TW_APIRequstResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TWAPITest.NativeMethodInfoPtr_OnResult_Private_Void_TW_APIRequstResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000C9F RID: 3231 RVA: 0x0004300C File Offset: 0x0004120C
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TWAPITest()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TWAPITest>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TWAPITest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CA0 RID: 3232 RVA: 0x000071DF File Offset: 0x000053DF
	public TWAPITest(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x040009D7 RID: 2519
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x040009D8 RID: 2520
	private static readonly IntPtr NativeMethodInfoPtr_OnResult_Private_Void_TW_APIRequstResult_0;

	// Token: 0x040009D9 RID: 2521
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
