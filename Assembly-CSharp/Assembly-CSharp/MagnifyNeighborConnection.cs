using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000038 RID: 56
public class MagnifyNeighborConnection : MonoBehaviour
{
	// Token: 0x060009D2 RID: 2514 RVA: 0x00037030 File Offset: 0x00035230
	// Note: this type is marked as 'beforefieldinit'.
	static MagnifyNeighborConnection()
	{
		Il2CppClassPointerStore<MagnifyNeighborConnection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MagnifyNeighborConnection");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MagnifyNeighborConnection>.NativeClassPtr);
		MagnifyNeighborConnection.NativeFieldInfoPtr_m_NeighborLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MagnifyNeighborConnection>.NativeClassPtr, "m_NeighborLeft");
		MagnifyNeighborConnection.NativeFieldInfoPtr_m_NeighborRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MagnifyNeighborConnection>.NativeClassPtr, "m_NeighborRight");
		MagnifyNeighborConnection.NativeMethodInfoPtr_GetNeighborLeft_Public_MagnifyNeighborConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MagnifyNeighborConnection>.NativeClassPtr, 100663980);
		MagnifyNeighborConnection.NativeMethodInfoPtr_GetNeighborRight_Public_MagnifyNeighborConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MagnifyNeighborConnection>.NativeClassPtr, 100663981);
		MagnifyNeighborConnection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MagnifyNeighborConnection>.NativeClassPtr, 100663982);
	}

	// Token: 0x060009D3 RID: 2515 RVA: 0x000370C4 File Offset: 0x000352C4
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MagnifyNeighborConnection GetNeighborLeft()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MagnifyNeighborConnection.NativeMethodInfoPtr_GetNeighborLeft_Public_MagnifyNeighborConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<MagnifyNeighborConnection>(intPtr3) : null;
	}

	// Token: 0x060009D4 RID: 2516 RVA: 0x00037104 File Offset: 0x00035304
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MagnifyNeighborConnection GetNeighborRight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MagnifyNeighborConnection.NativeMethodInfoPtr_GetNeighborRight_Public_MagnifyNeighborConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<MagnifyNeighborConnection>(intPtr3) : null;
	}

	// Token: 0x060009D5 RID: 2517 RVA: 0x00037144 File Offset: 0x00035344
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MagnifyNeighborConnection()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MagnifyNeighborConnection>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MagnifyNeighborConnection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009D6 RID: 2518 RVA: 0x00007FEA File Offset: 0x000061EA
	public MagnifyNeighborConnection(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000367 RID: 871
	// (get) Token: 0x060009D7 RID: 2519 RVA: 0x00037180 File Offset: 0x00035380
	// (set) Token: 0x060009D8 RID: 2520 RVA: 0x00007FF3 File Offset: 0x000061F3
	public unsafe MagnifyNeighborConnection m_NeighborLeft
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MagnifyNeighborConnection.NativeFieldInfoPtr_m_NeighborLeft);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MagnifyNeighborConnection>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MagnifyNeighborConnection.NativeFieldInfoPtr_m_NeighborLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000368 RID: 872
	// (get) Token: 0x060009D9 RID: 2521 RVA: 0x000371B0 File Offset: 0x000353B0
	// (set) Token: 0x060009DA RID: 2522 RVA: 0x00008012 File Offset: 0x00006212
	public unsafe MagnifyNeighborConnection m_NeighborRight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MagnifyNeighborConnection.NativeFieldInfoPtr_m_NeighborRight);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MagnifyNeighborConnection>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MagnifyNeighborConnection.NativeFieldInfoPtr_m_NeighborRight), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400061D RID: 1565
	private static readonly IntPtr NativeFieldInfoPtr_m_NeighborLeft;

	// Token: 0x0400061E RID: 1566
	private static readonly IntPtr NativeFieldInfoPtr_m_NeighborRight;

	// Token: 0x0400061F RID: 1567
	private static readonly IntPtr NativeMethodInfoPtr_GetNeighborLeft_Public_MagnifyNeighborConnection_0;

	// Token: 0x04000620 RID: 1568
	private static readonly IntPtr NativeMethodInfoPtr_GetNeighborRight_Public_MagnifyNeighborConnection_0;

	// Token: 0x04000621 RID: 1569
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
