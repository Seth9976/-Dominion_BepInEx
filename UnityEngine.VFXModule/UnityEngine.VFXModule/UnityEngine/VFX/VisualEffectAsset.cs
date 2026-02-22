using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine.VFX
{
	// Token: 0x02000008 RID: 8
	public class VisualEffectAsset : VisualEffectObject
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00004224 File Offset: 0x00002424
		// Note: this type is marked as 'beforefieldinit'.
		static VisualEffectAsset()
		{
			Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VisualEffectAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr);
			VisualEffectAsset.NativeFieldInfoPtr_PlayEventID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, "PlayEventID");
			VisualEffectAsset.NativeFieldInfoPtr_StopEventID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, "StopEventID");
			VisualEffectAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr, 100663319);
			VisualEffectAsset.GetTextureDimensionDelegateField = IL2CPP.ResolveICall<VisualEffectAsset.GetTextureDimensionDelegate>("UnityEngine.VFX.VisualEffectAsset::GetTextureDimension");
			VisualEffectAsset.GetEventsDelegateField = IL2CPP.ResolveICall<VisualEffectAsset.GetEventsDelegate>("UnityEngine.VFX.VisualEffectAsset::GetEvents");
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000042B0 File Offset: 0x000024B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualEffectAsset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualEffectAsset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualEffectAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002707 File Offset: 0x00000907
		public VisualEffectAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000AE RID: 174 RVA: 0x000042EC File Offset: 0x000024EC
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00002710 File Offset: 0x00000910
		public unsafe static int PlayEventID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(VisualEffectAsset.NativeFieldInfoPtr_PlayEventID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualEffectAsset.NativeFieldInfoPtr_PlayEventID, (void*)(&value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00004308 File Offset: 0x00002508
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x0000271E File Offset: 0x0000091E
		public unsafe static int StopEventID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(VisualEffectAsset.NativeFieldInfoPtr_StopEventID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualEffectAsset.NativeFieldInfoPtr_StopEventID, (void*)(&value));
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000272C File Offset: 0x0000092C
		public TextureDimension GetTextureDimension(int nameID)
		{
			return VisualEffectAsset.GetTextureDimensionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000273F File Offset: 0x0000093F
		public void GetEvents(List<string> names)
		{
			VisualEffectAsset.GetEventsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(names));
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00004324 File Offset: 0x00002524
		public TextureDimension GetTextureDimension(string name)
		{
			return this.GetTextureDimension(Shader.PropertyToID(name));
		}

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_PlayEventID;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_StopEventID;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000065 RID: 101
		public const string PlayEventName = "OnPlay";

		// Token: 0x04000066 RID: 102
		public const string StopEventName = "OnStop";

		// Token: 0x04000067 RID: 103
		private static readonly VisualEffectAsset.GetTextureDimensionDelegate GetTextureDimensionDelegateField;

		// Token: 0x04000068 RID: 104
		private static readonly VisualEffectAsset.GetEventsDelegate GetEventsDelegateField;

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x060001D6 RID: 470
		private delegate TextureDimension GetTextureDimensionDelegate(IntPtr @this, int nameID);

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x060001D8 RID: 472
		private delegate void GetEventsDelegate(IntPtr @this, IntPtr names);
	}
}
