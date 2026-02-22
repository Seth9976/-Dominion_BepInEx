using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000100 RID: 256
	public class Benchmark03 : MonoBehaviour
	{
		// Token: 0x06001E7E RID: 7806 RVA: 0x00077820 File Offset: 0x00075A20
		// Note: this type is marked as 'beforefieldinit'.
		static Benchmark03()
		{
			Il2CppClassPointerStore<Benchmark03>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro.Examples", "Benchmark03");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Benchmark03>.NativeClassPtr);
			Benchmark03.NativeFieldInfoPtr_SpawnType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark03>.NativeClassPtr, "SpawnType");
			Benchmark03.NativeFieldInfoPtr_NumberOfNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark03>.NativeClassPtr, "NumberOfNPC");
			Benchmark03.NativeFieldInfoPtr_TheFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark03>.NativeClassPtr, "TheFont");
			Benchmark03.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benchmark03>.NativeClassPtr, 100665813);
			Benchmark03.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benchmark03>.NativeClassPtr, 100665814);
			Benchmark03.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benchmark03>.NativeClassPtr, 100665815);
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x000778C8 File Offset: 0x00075AC8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Benchmark03.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x000778FC File Offset: 0x00075AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255770, XrefRangeEnd = 255806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Benchmark03.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x00077930 File Offset: 0x00075B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Benchmark03()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Benchmark03>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Benchmark03.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x0001302F File Offset: 0x0001122F
		public Benchmark03(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06001E83 RID: 7811 RVA: 0x0007796C File Offset: 0x00075B6C
		// (set) Token: 0x06001E84 RID: 7812 RVA: 0x00013038 File Offset: 0x00011238
		public unsafe int SpawnType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark03.NativeFieldInfoPtr_SpawnType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark03.NativeFieldInfoPtr_SpawnType)) = value;
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06001E85 RID: 7813 RVA: 0x00077994 File Offset: 0x00075B94
		// (set) Token: 0x06001E86 RID: 7814 RVA: 0x00013053 File Offset: 0x00011253
		public unsafe int NumberOfNPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark03.NativeFieldInfoPtr_NumberOfNPC);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark03.NativeFieldInfoPtr_NumberOfNPC)) = value;
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06001E87 RID: 7815 RVA: 0x000779BC File Offset: 0x00075BBC
		// (set) Token: 0x06001E88 RID: 7816 RVA: 0x0001306E File Offset: 0x0001126E
		public unsafe Font TheFont
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark03.NativeFieldInfoPtr_TheFont);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark03.NativeFieldInfoPtr_TheFont), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014AC RID: 5292
		private static readonly IntPtr NativeFieldInfoPtr_SpawnType;

		// Token: 0x040014AD RID: 5293
		private static readonly IntPtr NativeFieldInfoPtr_NumberOfNPC;

		// Token: 0x040014AE RID: 5294
		private static readonly IntPtr NativeFieldInfoPtr_TheFont;

		// Token: 0x040014AF RID: 5295
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040014B0 RID: 5296
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040014B1 RID: 5297
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
