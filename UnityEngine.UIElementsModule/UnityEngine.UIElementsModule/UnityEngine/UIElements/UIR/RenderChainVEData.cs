using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UIElements.UIR.Implementation;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020000D2 RID: 210
	public sealed class RenderChainVEData : ValueType
	{
		// Token: 0x06000BB4 RID: 2996 RVA: 0x000308A0 File Offset: 0x0002EAA0
		// Note: this type is marked as 'beforefieldinit'.
		static RenderChainVEData()
		{
			Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "RenderChainVEData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr);
			RenderChainVEData.NativeFieldInfoPtr_prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "prev");
			RenderChainVEData.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "next");
			RenderChainVEData.NativeFieldInfoPtr_groupTransformAncestor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "groupTransformAncestor");
			RenderChainVEData.NativeFieldInfoPtr_boneTransformAncestor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "boneTransformAncestor");
			RenderChainVEData.NativeFieldInfoPtr_prevDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "prevDirty");
			RenderChainVEData.NativeFieldInfoPtr_nextDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "nextDirty");
			RenderChainVEData.NativeFieldInfoPtr_hierarchyDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "hierarchyDepth");
			RenderChainVEData.NativeFieldInfoPtr_dirtiedValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "dirtiedValues");
			RenderChainVEData.NativeFieldInfoPtr_dirtyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "dirtyID");
			RenderChainVEData.NativeFieldInfoPtr_clipMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "clipMethod");
			RenderChainVEData.NativeFieldInfoPtr_firstCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "firstCommand");
			RenderChainVEData.NativeFieldInfoPtr_lastCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "lastCommand");
			RenderChainVEData.NativeFieldInfoPtr_firstClosingCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "firstClosingCommand");
			RenderChainVEData.NativeFieldInfoPtr_lastClosingCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "lastClosingCommand");
			RenderChainVEData.NativeFieldInfoPtr_isInChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "isInChain");
			RenderChainVEData.NativeFieldInfoPtr_isStencilClipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "isStencilClipped");
			RenderChainVEData.NativeFieldInfoPtr_isHierarchyHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "isHierarchyHidden");
			RenderChainVEData.NativeFieldInfoPtr_disableNudging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "disableNudging");
			RenderChainVEData.NativeFieldInfoPtr_usesLegacyText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "usesLegacyText");
			RenderChainVEData.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "data");
			RenderChainVEData.NativeFieldInfoPtr_closingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "closingData");
			RenderChainVEData.NativeFieldInfoPtr_verticesSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "verticesSpace");
			RenderChainVEData.NativeFieldInfoPtr_displacementUVStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "displacementUVStart");
			RenderChainVEData.NativeFieldInfoPtr_displacementUVEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "displacementUVEnd");
			RenderChainVEData.NativeFieldInfoPtr_transformID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "transformID");
			RenderChainVEData.NativeFieldInfoPtr_clipRectID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "clipRectID");
			RenderChainVEData.NativeFieldInfoPtr_opacityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "opacityID");
			RenderChainVEData.NativeFieldInfoPtr_textCoreSettingsID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "textCoreSettingsID");
			RenderChainVEData.NativeFieldInfoPtr_compositeOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "compositeOpacity");
			RenderChainVEData.NativeFieldInfoPtr_prevText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "prevText");
			RenderChainVEData.NativeFieldInfoPtr_nextText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "nextText");
			RenderChainVEData.NativeFieldInfoPtr_textEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "textEntries");
			RenderChainVEData.NativeFieldInfoPtr_textures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "textures");
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x0000753D File Offset: 0x0000573D
		public RenderChainVEData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x00007546 File Offset: 0x00005746
		public RenderChainVEData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr))
		{
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x00030B64 File Offset: 0x0002ED64
		// (set) Token: 0x06000BB8 RID: 3000 RVA: 0x00007558 File Offset: 0x00005758
		public unsafe VisualElement prev
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_prev);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_prev), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x00030B94 File Offset: 0x0002ED94
		// (set) Token: 0x06000BBA RID: 3002 RVA: 0x00007577 File Offset: 0x00005777
		public unsafe VisualElement next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x00030BC4 File Offset: 0x0002EDC4
		// (set) Token: 0x06000BBC RID: 3004 RVA: 0x00007596 File Offset: 0x00005796
		public unsafe VisualElement groupTransformAncestor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_groupTransformAncestor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_groupTransformAncestor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x00030BF4 File Offset: 0x0002EDF4
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x000075B5 File Offset: 0x000057B5
		public unsafe VisualElement boneTransformAncestor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_boneTransformAncestor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_boneTransformAncestor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x00030C24 File Offset: 0x0002EE24
		// (set) Token: 0x06000BC0 RID: 3008 RVA: 0x000075D4 File Offset: 0x000057D4
		public unsafe VisualElement prevDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_prevDirty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_prevDirty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x00030C54 File Offset: 0x0002EE54
		// (set) Token: 0x06000BC2 RID: 3010 RVA: 0x000075F3 File Offset: 0x000057F3
		public unsafe VisualElement nextDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_nextDirty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_nextDirty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x00030C84 File Offset: 0x0002EE84
		// (set) Token: 0x06000BC4 RID: 3012 RVA: 0x00007612 File Offset: 0x00005812
		public unsafe int hierarchyDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_hierarchyDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_hierarchyDepth)) = value;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x00030CAC File Offset: 0x0002EEAC
		// (set) Token: 0x06000BC6 RID: 3014 RVA: 0x0000762D File Offset: 0x0000582D
		public unsafe RenderDataDirtyTypes dirtiedValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_dirtiedValues);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_dirtiedValues)) = value;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x00030CD4 File Offset: 0x0002EED4
		// (set) Token: 0x06000BC8 RID: 3016 RVA: 0x00007648 File Offset: 0x00005848
		public unsafe uint dirtyID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_dirtyID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_dirtyID)) = value;
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x00030CFC File Offset: 0x0002EEFC
		// (set) Token: 0x06000BCA RID: 3018 RVA: 0x00007663 File Offset: 0x00005863
		public unsafe UnityEngine.UIElements.UIR.Implementation.ClipMethod clipMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_clipMethod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_clipMethod)) = value;
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x00030D24 File Offset: 0x0002EF24
		// (set) Token: 0x06000BCC RID: 3020 RVA: 0x0000767E File Offset: 0x0000587E
		public unsafe RenderChainCommand firstCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_firstCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderChainCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_firstCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x00030D54 File Offset: 0x0002EF54
		// (set) Token: 0x06000BCE RID: 3022 RVA: 0x0000769D File Offset: 0x0000589D
		public unsafe RenderChainCommand lastCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_lastCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderChainCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_lastCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x00030D84 File Offset: 0x0002EF84
		// (set) Token: 0x06000BD0 RID: 3024 RVA: 0x000076BC File Offset: 0x000058BC
		public unsafe RenderChainCommand firstClosingCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_firstClosingCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderChainCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_firstClosingCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x00030DB4 File Offset: 0x0002EFB4
		// (set) Token: 0x06000BD2 RID: 3026 RVA: 0x000076DB File Offset: 0x000058DB
		public unsafe RenderChainCommand lastClosingCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_lastClosingCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderChainCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_lastClosingCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x00030DE4 File Offset: 0x0002EFE4
		// (set) Token: 0x06000BD4 RID: 3028 RVA: 0x000076FA File Offset: 0x000058FA
		public unsafe bool isInChain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_isInChain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_isInChain)) = value;
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000BD5 RID: 3029 RVA: 0x00030E0C File Offset: 0x0002F00C
		// (set) Token: 0x06000BD6 RID: 3030 RVA: 0x00007715 File Offset: 0x00005915
		public unsafe bool isStencilClipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_isStencilClipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_isStencilClipped)) = value;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x00030E34 File Offset: 0x0002F034
		// (set) Token: 0x06000BD8 RID: 3032 RVA: 0x00007730 File Offset: 0x00005930
		public unsafe bool isHierarchyHidden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_isHierarchyHidden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_isHierarchyHidden)) = value;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x00030E5C File Offset: 0x0002F05C
		// (set) Token: 0x06000BDA RID: 3034 RVA: 0x0000774B File Offset: 0x0000594B
		public unsafe bool disableNudging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_disableNudging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_disableNudging)) = value;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x00030E84 File Offset: 0x0002F084
		// (set) Token: 0x06000BDC RID: 3036 RVA: 0x00007766 File Offset: 0x00005966
		public unsafe bool usesLegacyText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_usesLegacyText);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_usesLegacyText)) = value;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x00030EAC File Offset: 0x0002F0AC
		// (set) Token: 0x06000BDE RID: 3038 RVA: 0x00007781 File Offset: 0x00005981
		public unsafe MeshHandle data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x00030EDC File Offset: 0x0002F0DC
		// (set) Token: 0x06000BE0 RID: 3040 RVA: 0x000077A0 File Offset: 0x000059A0
		public unsafe MeshHandle closingData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_closingData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_closingData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x00030F0C File Offset: 0x0002F10C
		// (set) Token: 0x06000BE2 RID: 3042 RVA: 0x000077BF File Offset: 0x000059BF
		public unsafe Matrix4x4 verticesSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_verticesSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_verticesSpace)) = value;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x00030F34 File Offset: 0x0002F134
		// (set) Token: 0x06000BE4 RID: 3044 RVA: 0x000077DA File Offset: 0x000059DA
		public unsafe int displacementUVStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_displacementUVStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_displacementUVStart)) = value;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x00030F5C File Offset: 0x0002F15C
		// (set) Token: 0x06000BE6 RID: 3046 RVA: 0x000077F5 File Offset: 0x000059F5
		public unsafe int displacementUVEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_displacementUVEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_displacementUVEnd)) = value;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x00030F84 File Offset: 0x0002F184
		// (set) Token: 0x06000BE8 RID: 3048 RVA: 0x00007810 File Offset: 0x00005A10
		public unsafe BMPAlloc transformID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_transformID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_transformID)) = value;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x00030FAC File Offset: 0x0002F1AC
		// (set) Token: 0x06000BEA RID: 3050 RVA: 0x0000782B File Offset: 0x00005A2B
		public unsafe BMPAlloc clipRectID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_clipRectID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_clipRectID)) = value;
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000BEB RID: 3051 RVA: 0x00030FD4 File Offset: 0x0002F1D4
		// (set) Token: 0x06000BEC RID: 3052 RVA: 0x00007846 File Offset: 0x00005A46
		public unsafe BMPAlloc opacityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_opacityID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_opacityID)) = value;
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000BED RID: 3053 RVA: 0x00030FFC File Offset: 0x0002F1FC
		// (set) Token: 0x06000BEE RID: 3054 RVA: 0x00007861 File Offset: 0x00005A61
		public unsafe BMPAlloc textCoreSettingsID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_textCoreSettingsID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_textCoreSettingsID)) = value;
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000BEF RID: 3055 RVA: 0x00031024 File Offset: 0x0002F224
		// (set) Token: 0x06000BF0 RID: 3056 RVA: 0x0000787C File Offset: 0x00005A7C
		public unsafe float compositeOpacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_compositeOpacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_compositeOpacity)) = value;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x0003104C File Offset: 0x0002F24C
		// (set) Token: 0x06000BF2 RID: 3058 RVA: 0x00007897 File Offset: 0x00005A97
		public unsafe VisualElement prevText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_prevText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_prevText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x0003107C File Offset: 0x0002F27C
		// (set) Token: 0x06000BF4 RID: 3060 RVA: 0x000078B6 File Offset: 0x00005AB6
		public unsafe VisualElement nextText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_nextText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_nextText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x000310AC File Offset: 0x0002F2AC
		// (set) Token: 0x06000BF6 RID: 3062 RVA: 0x000078D5 File Offset: 0x00005AD5
		public unsafe List<RenderChainTextEntry> textEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_textEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RenderChainTextEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_textEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x000310DC File Offset: 0x0002F2DC
		// (set) Token: 0x06000BF8 RID: 3064 RVA: 0x000078F4 File Offset: 0x00005AF4
		public unsafe BasicNode<TextureEntry> textures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_textures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicNode<TextureEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_textures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x0003110C File Offset: 0x0002F30C
		public RenderChainCommand lastClosingOrLastCommand
		{
			get
			{
				return this.lastClosingCommand ?? this.lastCommand;
			}
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x00031130 File Offset: 0x0002F330
		public static bool AllocatesID(BMPAlloc alloc)
		{
			return alloc.ownedState == OwnedState.Owned && alloc.IsValid();
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x00031158 File Offset: 0x0002F358
		public static bool InheritsID(BMPAlloc alloc)
		{
			return alloc.ownedState == OwnedState.Inherited && alloc.IsValid();
		}

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeFieldInfoPtr_prev;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeFieldInfoPtr_next;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeFieldInfoPtr_groupTransformAncestor;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeFieldInfoPtr_boneTransformAncestor;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeFieldInfoPtr_prevDirty;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeFieldInfoPtr_nextDirty;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeFieldInfoPtr_hierarchyDepth;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeFieldInfoPtr_dirtiedValues;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeFieldInfoPtr_dirtyID;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeFieldInfoPtr_clipMethod;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeFieldInfoPtr_firstCommand;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeFieldInfoPtr_lastCommand;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeFieldInfoPtr_firstClosingCommand;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeFieldInfoPtr_lastClosingCommand;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeFieldInfoPtr_isInChain;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeFieldInfoPtr_isStencilClipped;

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeFieldInfoPtr_isHierarchyHidden;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeFieldInfoPtr_disableNudging;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeFieldInfoPtr_usesLegacyText;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeFieldInfoPtr_closingData;

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeFieldInfoPtr_verticesSpace;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeFieldInfoPtr_displacementUVStart;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeFieldInfoPtr_displacementUVEnd;

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeFieldInfoPtr_transformID;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeFieldInfoPtr_clipRectID;

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeFieldInfoPtr_opacityID;

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeFieldInfoPtr_textCoreSettingsID;

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeFieldInfoPtr_compositeOpacity;

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeFieldInfoPtr_prevText;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeFieldInfoPtr_nextText;

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeFieldInfoPtr_textEntries;

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeFieldInfoPtr_textures;
	}
}
