using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x0200010F RID: 271
	public class TMP_TextInfoDebugTool : MonoBehaviour
	{
		// Token: 0x06001F98 RID: 8088 RVA: 0x0007A544 File Offset: 0x00078744
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_TextInfoDebugTool()
		{
			Il2CppClassPointerStore<TMP_TextInfoDebugTool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro.Examples", "TMP_TextInfoDebugTool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_TextInfoDebugTool>.NativeClassPtr);
			TMP_TextInfoDebugTool.NativeFieldInfoPtr_ShowCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfoDebugTool>.NativeClassPtr, "ShowCharacters");
			TMP_TextInfoDebugTool.NativeFieldInfoPtr_ShowWords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfoDebugTool>.NativeClassPtr, "ShowWords");
			TMP_TextInfoDebugTool.NativeFieldInfoPtr_ShowLinks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfoDebugTool>.NativeClassPtr, "ShowLinks");
			TMP_TextInfoDebugTool.NativeFieldInfoPtr_ShowLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfoDebugTool>.NativeClassPtr, "ShowLines");
			TMP_TextInfoDebugTool.NativeFieldInfoPtr_ShowMeshBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfoDebugTool>.NativeClassPtr, "ShowMeshBounds");
			TMP_TextInfoDebugTool.NativeFieldInfoPtr_ShowTextBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfoDebugTool>.NativeClassPtr, "ShowTextBounds");
			TMP_TextInfoDebugTool.NativeFieldInfoPtr_ObjectStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfoDebugTool>.NativeClassPtr, "ObjectStats");
			TMP_TextInfoDebugTool.NativeFieldInfoPtr_m_TextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfoDebugTool>.NativeClassPtr, "m_TextComponent");
			TMP_TextInfoDebugTool.NativeFieldInfoPtr_m_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfoDebugTool>.NativeClassPtr, "m_Transform");
			TMP_TextInfoDebugTool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfoDebugTool>.NativeClassPtr, 100665875);
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x0007A63C File Offset: 0x0007883C
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_TextInfoDebugTool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_TextInfoDebugTool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfoDebugTool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x00013B11 File Offset: 0x00011D11
		public TMP_TextInfoDebugTool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06001F9B RID: 8091 RVA: 0x0007A678 File Offset: 0x00078878
		// (set) Token: 0x06001F9C RID: 8092 RVA: 0x00013B1A File Offset: 0x00011D1A
		public unsafe bool ShowCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfoDebugTool.NativeFieldInfoPtr_ShowCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfoDebugTool.NativeFieldInfoPtr_ShowCharacters)) = value;
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06001F9D RID: 8093 RVA: 0x0007A6A0 File Offset: 0x000788A0
		// (set) Token: 0x06001F9E RID: 8094 RVA: 0x00013B35 File Offset: 0x00011D35
		public unsafe bool ShowWords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfoDebugTool.NativeFieldInfoPtr_ShowWords);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfoDebugTool.NativeFieldInfoPtr_ShowWords)) = value;
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06001F9F RID: 8095 RVA: 0x0007A6C8 File Offset: 0x000788C8
		// (set) Token: 0x06001FA0 RID: 8096 RVA: 0x00013B50 File Offset: 0x00011D50
		public unsafe bool ShowLinks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfoDebugTool.NativeFieldInfoPtr_ShowLinks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfoDebugTool.NativeFieldInfoPtr_ShowLinks)) = value;
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06001FA1 RID: 8097 RVA: 0x0007A6F0 File Offset: 0x000788F0
		// (set) Token: 0x06001FA2 RID: 8098 RVA: 0x00013B6B File Offset: 0x00011D6B
		public unsafe bool ShowLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfoDebugTool.NativeFieldInfoPtr_ShowLines);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfoDebugTool.NativeFieldInfoPtr_ShowLines)) = value;
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x0007A718 File Offset: 0x00078918
		// (set) Token: 0x06001FA4 RID: 8100 RVA: 0x00013B86 File Offset: 0x00011D86
		public unsafe bool ShowMeshBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfoDebugTool.NativeFieldInfoPtr_ShowMeshBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfoDebugTool.NativeFieldInfoPtr_ShowMeshBounds)) = value;
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x0007A740 File Offset: 0x00078940
		// (set) Token: 0x06001FA6 RID: 8102 RVA: 0x00013BA1 File Offset: 0x00011DA1
		public unsafe bool ShowTextBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfoDebugTool.NativeFieldInfoPtr_ShowTextBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfoDebugTool.NativeFieldInfoPtr_ShowTextBounds)) = value;
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06001FA7 RID: 8103 RVA: 0x0007A768 File Offset: 0x00078968
		// (set) Token: 0x06001FA8 RID: 8104 RVA: 0x00013BBC File Offset: 0x00011DBC
		public unsafe string ObjectStats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfoDebugTool.NativeFieldInfoPtr_ObjectStats);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfoDebugTool.NativeFieldInfoPtr_ObjectStats), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06001FA9 RID: 8105 RVA: 0x0007A790 File Offset: 0x00078990
		// (set) Token: 0x06001FAA RID: 8106 RVA: 0x00013BDB File Offset: 0x00011DDB
		public unsafe TMP_Text m_TextComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfoDebugTool.NativeFieldInfoPtr_m_TextComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfoDebugTool.NativeFieldInfoPtr_m_TextComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06001FAB RID: 8107 RVA: 0x0007A7C0 File Offset: 0x000789C0
		// (set) Token: 0x06001FAC RID: 8108 RVA: 0x00013BFA File Offset: 0x00011DFA
		public unsafe Transform m_Transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfoDebugTool.NativeFieldInfoPtr_m_Transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfoDebugTool.NativeFieldInfoPtr_m_Transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001549 RID: 5449
		private static readonly IntPtr NativeFieldInfoPtr_ShowCharacters;

		// Token: 0x0400154A RID: 5450
		private static readonly IntPtr NativeFieldInfoPtr_ShowWords;

		// Token: 0x0400154B RID: 5451
		private static readonly IntPtr NativeFieldInfoPtr_ShowLinks;

		// Token: 0x0400154C RID: 5452
		private static readonly IntPtr NativeFieldInfoPtr_ShowLines;

		// Token: 0x0400154D RID: 5453
		private static readonly IntPtr NativeFieldInfoPtr_ShowMeshBounds;

		// Token: 0x0400154E RID: 5454
		private static readonly IntPtr NativeFieldInfoPtr_ShowTextBounds;

		// Token: 0x0400154F RID: 5455
		private static readonly IntPtr NativeFieldInfoPtr_ObjectStats;

		// Token: 0x04001550 RID: 5456
		private static readonly IntPtr NativeFieldInfoPtr_m_TextComponent;

		// Token: 0x04001551 RID: 5457
		private static readonly IntPtr NativeFieldInfoPtr_m_Transform;

		// Token: 0x04001552 RID: 5458
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
