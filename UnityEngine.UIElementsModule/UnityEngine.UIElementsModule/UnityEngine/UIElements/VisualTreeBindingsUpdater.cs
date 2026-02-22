using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x02000132 RID: 306
	public class VisualTreeBindingsUpdater : BaseVisualTreeHierarchyTrackerUpdater
	{
		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x000090FC File Offset: 0x000072FC
		public override ProfilerMarker profilerMarker
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x00009109 File Offset: 0x00007309
		// (set) Token: 0x06000E46 RID: 3654 RVA: 0x00009116 File Offset: 0x00007316
		public static bool disableBindingsThrottling
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x00035950 File Offset: 0x00033B50
		public IBinding GetBindingObjectFromElement(VisualElement ve)
		{
			IBindable bindable = ve.TryCast<IBindable>();
			bool flag = bindable != null;
			if (flag)
			{
				bool flag2 = bindable.binding != null;
				if (flag2)
				{
					return bindable.binding;
				}
			}
			return VisualTreeBindingsUpdater.GetAdditionalBinding(ve);
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x00009123 File Offset: 0x00007323
		public void StartTracking(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x00009130 File Offset: 0x00007330
		public void StopTracking(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x0000913D File Offset: 0x0000733D
		// (set) Token: 0x06000E4B RID: 3659 RVA: 0x0000914A File Offset: 0x0000734A
		public Dictionary<Object, Object> temporaryObjectCache
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00009157 File Offset: 0x00007357
		public static void SetAdditionalBinding(VisualElement ve, IBinding b)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x00009164 File Offset: 0x00007364
		public static void ClearAdditionalBinding(VisualElement ve)
		{
			VisualTreeBindingsUpdater.SetAdditionalBinding(ve, null);
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x0000916F File Offset: 0x0000736F
		public static IBinding GetAdditionalBinding(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x0000917C File Offset: 0x0000737C
		public static void AddBindingRequest(VisualElement ve, IBindingRequest req)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x00009189 File Offset: 0x00007389
		public static void RemoveBindingRequest(VisualElement ve, IBindingRequest req)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x00009196 File Offset: 0x00007396
		public static void ClearBindingRequests(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x000091A3 File Offset: 0x000073A3
		public void StartTrackingRecursive(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x000091B0 File Offset: 0x000073B0
		public void StopTrackingRecursive(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x000091BD File Offset: 0x000073BD
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x00035990 File Offset: 0x00033B90
		public override void OnHierarchyChange(VisualElement ve, HierarchyChangeType type)
		{
			if (type != HierarchyChangeType.Add)
			{
				if (type == HierarchyChangeType.Remove)
				{
					this.StopTrackingRecursive(ve);
				}
			}
			else
			{
				this.StartTrackingRecursive(ve);
			}
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x000359C4 File Offset: 0x00033BC4
		public static long CurrentTime()
		{
			return Panel.TimeSinceStartupMs();
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x000359DC File Offset: 0x00033BDC
		public static bool ShouldThrottle(long startTime)
		{
			return !VisualTreeBindingsUpdater.disableBindingsThrottling && VisualTreeBindingsUpdater.CurrentTime() - startTime < 100L;
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x000091CA File Offset: 0x000073CA
		public void PerformTrackingOperations()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x000091D7 File Offset: 0x000073D7
		public override void Update()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x000091E4 File Offset: 0x000073E4
		public void UpdateBindings()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040007A6 RID: 1958
		public const int k_MinUpdateDelayMs = 100;

		// Token: 0x040007A7 RID: 1959
		public const int k_MaxBindingTimeMs = 100;

		// Token: 0x02000244 RID: 580
		public class RequestObjectListPool : ObjectListPool<IBindingRequest>
		{
		}
	}
}
