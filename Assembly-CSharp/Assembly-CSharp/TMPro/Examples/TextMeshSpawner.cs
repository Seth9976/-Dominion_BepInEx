using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x0200010A RID: 266
	public class TextMeshSpawner : MonoBehaviour
	{
		// Token: 0x06001F45 RID: 8005 RVA: 0x00079734 File Offset: 0x00077934
		// Note: this type is marked as 'beforefieldinit'.
		static TextMeshSpawner()
		{
			Il2CppClassPointerStore<TextMeshSpawner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro.Examples", "TextMeshSpawner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextMeshSpawner>.NativeClassPtr);
			TextMeshSpawner.NativeFieldInfoPtr_SpawnType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshSpawner>.NativeClassPtr, "SpawnType");
			TextMeshSpawner.NativeFieldInfoPtr_NumberOfNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshSpawner>.NativeClassPtr, "NumberOfNPC");
			TextMeshSpawner.NativeFieldInfoPtr_TheFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshSpawner>.NativeClassPtr, "TheFont");
			TextMeshSpawner.NativeFieldInfoPtr_floatingText_Script = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshSpawner>.NativeClassPtr, "floatingText_Script");
			TextMeshSpawner.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshSpawner>.NativeClassPtr, 100665854);
			TextMeshSpawner.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshSpawner>.NativeClassPtr, 100665855);
			TextMeshSpawner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshSpawner>.NativeClassPtr, 100665856);
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x000797F0 File Offset: 0x000779F0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshSpawner.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x00079824 File Offset: 0x00077A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256328, XrefRangeEnd = 256372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshSpawner.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x00079858 File Offset: 0x00077A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextMeshSpawner()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextMeshSpawner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshSpawner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x00013811 File Offset: 0x00011A11
		public TextMeshSpawner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06001F4A RID: 8010 RVA: 0x00079894 File Offset: 0x00077A94
		// (set) Token: 0x06001F4B RID: 8011 RVA: 0x0001381A File Offset: 0x00011A1A
		public unsafe int SpawnType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshSpawner.NativeFieldInfoPtr_SpawnType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshSpawner.NativeFieldInfoPtr_SpawnType)) = value;
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06001F4C RID: 8012 RVA: 0x000798BC File Offset: 0x00077ABC
		// (set) Token: 0x06001F4D RID: 8013 RVA: 0x00013835 File Offset: 0x00011A35
		public unsafe int NumberOfNPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshSpawner.NativeFieldInfoPtr_NumberOfNPC);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshSpawner.NativeFieldInfoPtr_NumberOfNPC)) = value;
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06001F4E RID: 8014 RVA: 0x000798E4 File Offset: 0x00077AE4
		// (set) Token: 0x06001F4F RID: 8015 RVA: 0x00013850 File Offset: 0x00011A50
		public unsafe Font TheFont
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshSpawner.NativeFieldInfoPtr_TheFont);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshSpawner.NativeFieldInfoPtr_TheFont), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06001F50 RID: 8016 RVA: 0x00079914 File Offset: 0x00077B14
		// (set) Token: 0x06001F51 RID: 8017 RVA: 0x0001386F File Offset: 0x00011A6F
		public unsafe TextMeshProFloatingText floatingText_Script
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshSpawner.NativeFieldInfoPtr_floatingText_Script);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProFloatingText>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshSpawner.NativeFieldInfoPtr_floatingText_Script), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400151A RID: 5402
		private static readonly IntPtr NativeFieldInfoPtr_SpawnType;

		// Token: 0x0400151B RID: 5403
		private static readonly IntPtr NativeFieldInfoPtr_NumberOfNPC;

		// Token: 0x0400151C RID: 5404
		private static readonly IntPtr NativeFieldInfoPtr_TheFont;

		// Token: 0x0400151D RID: 5405
		private static readonly IntPtr NativeFieldInfoPtr_floatingText_Script;

		// Token: 0x0400151E RID: 5406
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400151F RID: 5407
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001520 RID: 5408
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
