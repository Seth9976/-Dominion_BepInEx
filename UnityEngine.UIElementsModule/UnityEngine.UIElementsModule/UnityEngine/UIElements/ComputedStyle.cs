using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.Yoga;

namespace UnityEngine.UIElements
{
	// Token: 0x020000AD RID: 173
	public class ComputedStyle : Object
	{
		// Token: 0x06000907 RID: 2311 RVA: 0x00029C70 File Offset: 0x00027E70
		// Note: this type is marked as 'beforefieldinit'.
		static ComputedStyle()
		{
			Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ComputedStyle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr);
			ComputedStyle.NativeFieldInfoPtr_isShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, "isShared");
			ComputedStyle.NativeFieldInfoPtr_yogaNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, "yogaNode");
			ComputedStyle.NativeFieldInfoPtr_m_CustomProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, "m_CustomProperties");
			ComputedStyle.NativeFieldInfoPtr_dpiScaling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, "dpiScaling");
			ComputedStyle.NativeFieldInfoPtr_inheritedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, "inheritedData");
			ComputedStyle.NativeFieldInfoPtr_nonInheritedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, "nonInheritedData");
			ComputedStyle.NativeMethodInfoPtr_get_display_Public_get_DisplayStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100664163);
			ComputedStyle.NativeMethodInfoPtr_get_overflow_Public_get_OverflowInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100664164);
			ComputedStyle.NativeMethodInfoPtr_get_visibility_Public_get_Visibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedStyle>.NativeClassPtr, 100664165);
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x00029D54 File Offset: 0x00027F54
		public unsafe DisplayStyle display
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 96662, RefRangeEnd = 96663, XrefRangeStart = 96662, XrefRangeEnd = 96662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_display_Public_get_DisplayStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x00029D90 File Offset: 0x00027F90
		public unsafe OverflowInternal overflow
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 96663, RefRangeEnd = 96665, XrefRangeStart = 96663, XrefRangeEnd = 96663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_overflow_Public_get_OverflowInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x00029DCC File Offset: 0x00027FCC
		public unsafe Visibility visibility
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 24292, RefRangeEnd = 24293, XrefRangeStart = 24292, XrefRangeEnd = 24293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedStyle.NativeMethodInfoPtr_get_visibility_Public_get_Visibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00005CA0 File Offset: 0x00003EA0
		public ComputedStyle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x00029E08 File Offset: 0x00028008
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x00005CA9 File Offset: 0x00003EA9
		public unsafe bool isShared
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_isShared);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_isShared)) = value;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x00029E30 File Offset: 0x00028030
		// (set) Token: 0x0600090F RID: 2319 RVA: 0x00005CC4 File Offset: 0x00003EC4
		public unsafe YogaNode yogaNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_yogaNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<YogaNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_yogaNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x00029E60 File Offset: 0x00028060
		// (set) Token: 0x06000911 RID: 2321 RVA: 0x00005CE3 File Offset: 0x00003EE3
		public unsafe Dictionary<string, UnityEngine.UIElements.StyleSheets.StylePropertyValue> m_CustomProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_m_CustomProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, UnityEngine.UIElements.StyleSheets.StylePropertyValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_m_CustomProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x00029E90 File Offset: 0x00028090
		// (set) Token: 0x06000913 RID: 2323 RVA: 0x00005D02 File Offset: 0x00003F02
		public unsafe float dpiScaling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_dpiScaling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_dpiScaling)) = value;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x00029EB8 File Offset: 0x000280B8
		// (set) Token: 0x06000915 RID: 2325 RVA: 0x00005D1D File Offset: 0x00003F1D
		public InheritedData inheritedData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_inheritedData);
				return new InheritedData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_inheritedData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x00029EE8 File Offset: 0x000280E8
		// (set) Token: 0x06000917 RID: 2327 RVA: 0x00005D4B File Offset: 0x00003F4B
		public NonInheritedData nonInheritedData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_nonInheritedData);
				return new NonInheritedData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NonInheritedData>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedStyle.NativeFieldInfoPtr_nonInheritedData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NonInheritedData>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x00029F18 File Offset: 0x00028118
		public int customPropertiesCount
		{
			get
			{
				return (this.m_CustomProperties != null) ? this.m_CustomProperties.Count : 0;
			}
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00029F40 File Offset: 0x00028140
		public static ComputedStyle Create([Optional] bool isShared)
		{
			ComputedStyle computedStyle = new ComputedStyle(isShared);
			computedStyle.CopyFrom(UnityEngine.UIElements.StyleSheets.InitialStyle.Get());
			return computedStyle;
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00029F68 File Offset: 0x00028168
		public static ComputedStyle Create(ComputedStyle parentStyle, [Optional] bool isShared)
		{
			ComputedStyle computedStyle = ComputedStyle.Create(isShared);
			bool flag = parentStyle != null;
			if (flag)
			{
				computedStyle.inheritedData = parentStyle.inheritedData;
			}
			return computedStyle;
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x00029F98 File Offset: 0x00028198
		public static ComputedStyle CreateUninitialized([Optional] bool isShared)
		{
			return new ComputedStyle(isShared);
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x00005D79 File Offset: 0x00003F79
		public void CopyShared(ComputedStyle sharedStyle)
		{
			this.m_CustomProperties = sharedStyle.m_CustomProperties;
			this.CopyFrom(sharedStyle);
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00005D90 File Offset: 0x00003F90
		public void FinalizeApply(ComputedStyle parentStyle)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00005D9D File Offset: 0x00003F9D
		public void SyncWithLayout(YogaNode targetNode)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x00029FB0 File Offset: 0x000281B0
		public bool ApplyGlobalKeyword(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ComputedStyle parentStyle)
		{
			StyleValueHandle handle = reader.GetValue(0).handle;
			bool flag = handle.valueType == StyleValueType.Keyword;
			if (flag)
			{
				bool flag2 = handle.valueIndex == 1;
				if (flag2)
				{
					this.ApplyInitialValue(reader);
					return true;
				}
				bool flag3 = handle.valueIndex == 3;
				if (flag3)
				{
					bool flag4 = parentStyle == null;
					if (flag4)
					{
						this.ApplyInitialValue(reader);
					}
					else
					{
						this.ApplyUnsetValue(reader, parentStyle);
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x0002A02C File Offset: 0x0002822C
		public bool ApplyGlobalKeyword(UnityEngine.UIElements.StyleSheets.StyleValue sv, ComputedStyle parentStyle)
		{
			bool flag = sv.keyword == StyleKeyword.Initial;
			bool flag2;
			if (flag)
			{
				this.ApplyInitialValue(sv.id);
				flag2 = true;
			}
			else
			{
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0002A060 File Offset: 0x00028260
		public void RemoveCustomStyleProperty(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader)
		{
			string name = reader.property.name;
			bool flag = this.m_CustomProperties == null || !this.m_CustomProperties.ContainsKey(name);
			if (!flag)
			{
				this.m_CustomProperties.Remove(name);
			}
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x0002A0A8 File Offset: 0x000282A8
		public void ApplyCustomStyleProperty(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader)
		{
			this.dpiScaling = reader.dpiScaling;
			bool flag = this.m_CustomProperties == null;
			if (flag)
			{
				this.m_CustomProperties = new Dictionary<string, UnityEngine.UIElements.StyleSheets.StylePropertyValue>();
			}
			StyleProperty property = reader.property;
			UnityEngine.UIElements.StyleSheets.StylePropertyValue value = reader.GetValue(0);
			this.m_CustomProperties[property.name] = value;
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x0002A100 File Offset: 0x00028300
		public bool TryGetValue(string propertyName, StyleValueType valueType, out UnityEngine.UIElements.StyleSheets.StylePropertyValue customProp)
		{
			customProp = null;
			bool flag = this.m_CustomProperties != null && this.m_CustomProperties.TryGetValue(propertyName, out customProp);
			bool flag3;
			if (flag)
			{
				bool flag2 = customProp.handle.valueType != valueType;
				if (flag2)
				{
					ComputedStyle.LogCustomPropertyWarning(propertyName, valueType, customProp);
					flag3 = false;
				}
				else
				{
					flag3 = true;
				}
			}
			else
			{
				flag3 = false;
			}
			return flag3;
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00005DAA File Offset: 0x00003FAA
		public static void LogCustomPropertyWarning(string propertyName, StyleValueType valueType, UnityEngine.UIElements.StyleSheets.StylePropertyValue customProp)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x00005DB7 File Offset: 0x00003FB7
		public Align alignContent
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x00005DC4 File Offset: 0x00003FC4
		public Align alignItems
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x00005DD1 File Offset: 0x00003FD1
		public Align alignSelf
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x00005DDE File Offset: 0x00003FDE
		public Color backgroundColor
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x00005DEB File Offset: 0x00003FEB
		public Background backgroundImage
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x00005DF8 File Offset: 0x00003FF8
		public Color borderBottomColor
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x00005E05 File Offset: 0x00004005
		public Length borderBottomLeftRadius
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x00005E12 File Offset: 0x00004012
		public Length borderBottomRightRadius
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x00005E1F File Offset: 0x0000401F
		public float borderBottomWidth
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x00005E2C File Offset: 0x0000402C
		public Color borderLeftColor
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x00005E39 File Offset: 0x00004039
		public float borderLeftWidth
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x00005E46 File Offset: 0x00004046
		public Color borderRightColor
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x00005E53 File Offset: 0x00004053
		public float borderRightWidth
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x00005E60 File Offset: 0x00004060
		public Color borderTopColor
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x00005E6D File Offset: 0x0000406D
		public Length borderTopLeftRadius
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x00005E7A File Offset: 0x0000407A
		public Length borderTopRightRadius
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x00005E87 File Offset: 0x00004087
		public float borderTopWidth
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x00005E94 File Offset: 0x00004094
		public Length bottom
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x00005EA1 File Offset: 0x000040A1
		public Color color
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x00005EAE File Offset: 0x000040AE
		public Cursor cursor
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x00005EBB File Offset: 0x000040BB
		public Length flexBasis
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x00005EC8 File Offset: 0x000040C8
		public FlexDirection flexDirection
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x00005ED5 File Offset: 0x000040D5
		public float flexGrow
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x00005EE2 File Offset: 0x000040E2
		public float flexShrink
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x00005EEF File Offset: 0x000040EF
		public Wrap flexWrap
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x00005EFC File Offset: 0x000040FC
		public Length fontSize
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x00005F09 File Offset: 0x00004109
		public Length height
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x00005F16 File Offset: 0x00004116
		public Justify justifyContent
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x00005F23 File Offset: 0x00004123
		public Length left
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x00005F30 File Offset: 0x00004130
		public Length marginBottom
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x00005F3D File Offset: 0x0000413D
		public Length marginLeft
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x00005F4A File Offset: 0x0000414A
		public Length marginRight
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x00005F57 File Offset: 0x00004157
		public Length marginTop
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x00005F64 File Offset: 0x00004164
		public Length maxHeight
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x00005F71 File Offset: 0x00004171
		public Length maxWidth
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x00005F7E File Offset: 0x0000417E
		public Length minHeight
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x00005F8B File Offset: 0x0000418B
		public Length minWidth
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x00005F98 File Offset: 0x00004198
		public float opacity
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x00005FA5 File Offset: 0x000041A5
		public Length paddingBottom
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x0600094C RID: 2380 RVA: 0x00005FB2 File Offset: 0x000041B2
		public Length paddingLeft
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x00005FBF File Offset: 0x000041BF
		public Length paddingRight
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x00005FCC File Offset: 0x000041CC
		public Length paddingTop
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x00005FD9 File Offset: 0x000041D9
		public Position position
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x00005FE6 File Offset: 0x000041E6
		public Length right
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x00005FF3 File Offset: 0x000041F3
		public TextOverflow textOverflow
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x00006000 File Offset: 0x00004200
		public Length top
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x0000600D File Offset: 0x0000420D
		public Color unityBackgroundImageTintColor
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x0000601A File Offset: 0x0000421A
		public ScaleMode unityBackgroundScaleMode
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x00006027 File Offset: 0x00004227
		public Font unityFont
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x00006034 File Offset: 0x00004234
		public FontStyle unityFontStyleAndWeight
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x00006041 File Offset: 0x00004241
		public OverflowClipBox unityOverflowClipBox
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x0000604E File Offset: 0x0000424E
		public int unitySliceBottom
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x0000605B File Offset: 0x0000425B
		public int unitySliceLeft
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x00006068 File Offset: 0x00004268
		public int unitySliceRight
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x00006075 File Offset: 0x00004275
		public int unitySliceTop
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x00006082 File Offset: 0x00004282
		public TextAnchor unityTextAlign
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x0000608F File Offset: 0x0000428F
		public TextOverflowPosition unityTextOverflowPosition
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x0000609C File Offset: 0x0000429C
		public WhiteSpace whiteSpace
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x000060A9 File Offset: 0x000042A9
		public Length width
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x000060B6 File Offset: 0x000042B6
		public void CopyFrom(ComputedStyle other)
		{
			this.inheritedData = other.inheritedData;
			this.nonInheritedData = other.nonInheritedData;
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x000060D1 File Offset: 0x000042D1
		public void ApplyProperties(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ComputedStyle parentStyle)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x000060DE File Offset: 0x000042DE
		public void ApplyStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue sv, ComputedStyle parentStyle)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x000060EB File Offset: 0x000042EB
		public void ApplyStyleCursor(Cursor cursor)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0002A168 File Offset: 0x00028368
		public void ApplyInitialValue(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader)
		{
			UnityEngine.UIElements.StyleSheets.StylePropertyId propertyId = reader.propertyId;
			UnityEngine.UIElements.StyleSheets.StylePropertyId stylePropertyId = propertyId;
			if (stylePropertyId != UnityEngine.UIElements.StyleSheets.StylePropertyId.Custom)
			{
				this.ApplyInitialValue(reader.propertyId);
			}
			else
			{
				this.RemoveCustomStyleProperty(reader);
			}
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x000060F8 File Offset: 0x000042F8
		public void ApplyInitialValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x0002A1A0 File Offset: 0x000283A0
		public void ApplyUnsetValue(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, ComputedStyle parentStyle)
		{
			UnityEngine.UIElements.StyleSheets.StylePropertyId propertyId = reader.propertyId;
			UnityEngine.UIElements.StyleSheets.StylePropertyId stylePropertyId = propertyId;
			if (stylePropertyId != UnityEngine.UIElements.StyleSheets.StylePropertyId.Custom)
			{
				this.ApplyUnsetValue(reader.propertyId, parentStyle);
			}
			else
			{
				this.RemoveCustomStyleProperty(reader);
			}
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00006105 File Offset: 0x00004305
		public void ApplyUnsetValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, ComputedStyle parentStyle)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeFieldInfoPtr_isShared;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeFieldInfoPtr_yogaNode;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeFieldInfoPtr_m_CustomProperties;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeFieldInfoPtr_dpiScaling;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeFieldInfoPtr_inheritedData;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeFieldInfoPtr_nonInheritedData;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeMethodInfoPtr_get_display_Public_get_DisplayStyle_0;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeMethodInfoPtr_get_overflow_Public_get_OverflowInternal_0;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr_get_visibility_Public_get_Visibility_0;
	}
}
